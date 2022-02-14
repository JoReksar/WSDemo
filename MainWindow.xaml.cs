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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AntiquesShop.Database;
using AntiquesShop.Database.Models;
using AntiquesShop.Windows;

namespace AntiquesShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new CommonTableWindow<Antiques>(nameof(Antiques), AntiquesShopDatabase.Instance.Antiques.ToList())
                .ShowDialog();
          }
    }
}
