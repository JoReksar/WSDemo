using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AntiquesShop.Database.Models;
using AntiquesShop.Database.Models.Enums;
using AntiquesShop.ViewModels;

namespace AntiquesShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private readonly AuthorizationViewModel _viewModel;

        public AuthorizationWindow()
        {
            InitializeComponent();
            _viewModel = new AuthorizationViewModel();

            _viewModel.PropertyChanged += (_, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(_viewModel.ErrorMessage):
                        MessageBox.Show(_viewModel.ErrorMessage);
                        break;
                    case nameof(_viewModel.CurrentUser):
                        if (_viewModel.CurrentUser is not null)
                            HandleWindowByUser(_viewModel.CurrentUser);
                        Close();
                        break;
                }
            };

            LoginTextBox.TextChanged += (sender, _) => _viewModel.InputLogin = LoginTextBox.Text;
            PasswordTextBox.TextChanged += (sender, _) => _viewModel.InputLogin = PasswordTextBox.Text;

            LoginButton.Click += (_, _) => _viewModel.AuthorizeCommand.Execute(null);
        }

        private void HandleWindowByUser(User user)
        {
            (user.Role switch
            {
                Role.Administrator => new CommonTableWindow<RegistrationData>("Администратор", null!),
                Role.Director => new CommonTableWindow<Antiques>("Директор", null!),
                Role.Manager => (Window)new CommonTableWindow<Order>("Менеджер", null!),
                _ => throw new ArgumentOutOfRangeException()
            }).ShowDialog();
        }
    }
}
