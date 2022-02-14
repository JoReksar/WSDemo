using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using AntiquesShop.Database;
using AntiquesShop.Database.Models;
using AntiquesShop.Database.Models.Enums;
using AntiquesShop.Utilities;

namespace AntiquesShop.ViewModels
{
    internal class AuthorizationViewModel : BaseNotifyPropertyChanged
    {
        private static readonly AntiquesShopDatabase _database = AntiquesShopDatabase.Instance;

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set => Set(ref _errorMessage, value);
        }

        private User? _currentUser;
        public User? CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        public string? InputLogin { get; set; }
        public string? InputPassword { get; set; }

        public ICommand AuthorizeCommand { get; }


        public AuthorizationViewModel()
        {
            
            AuthorizeCommand = new Command(async _ => await OnAuthorizeClick(_),
                _ => !(string.IsNullOrEmpty(InputLogin) || string.IsNullOrEmpty(InputPassword)));
        }

        private async Task OnAuthorizeClick(object? _)
        {
            var userInfo = await _database.Registrations.FirstOrDefaultAsync(
                registerInfo => registerInfo.Login == InputLogin && 
                                registerInfo.HashedPassword == InputPassword);

            if (userInfo is null)
            {
                ErrorMessage = "Такого пользователя не существует";
                _errorMessage = string.Empty;
            }
            else
                CurrentUser = userInfo.User;
        }


    }
}
