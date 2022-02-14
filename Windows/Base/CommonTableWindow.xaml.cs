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

namespace AntiquesShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для CommonTableWindow.xaml
    /// </summary>
    public partial class CommonTableWindow : Window
    {
        protected DataGrid Table => CommonTable;
        protected Button AddButton => CommonAddButton;
        protected Button EditButton => CommonEditButton;
        protected Button DeleteButton => CommonDeleteButton;
        protected Button SearchButton => CommonSearchButton;
        protected TextBox SearchTextBox => CommonSearchTextBox;

        protected CommonTableWindow()
        {
            InitializeComponent();
        }
    }
}
