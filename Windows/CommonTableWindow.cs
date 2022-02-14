using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.ViewModels;

namespace AntiquesShop.Windows
{
    public sealed class CommonTableWindow<T> : CommonTableWindow
    {
        // Смысл от ViewModel?
        private readonly CommonTableViewModel<T> ViewModel;

        public CommonTableWindow(string windowTitle, IEnumerable<T> items)
        {
            Title = windowTitle;
            ViewModel = new CommonTableViewModel<T>(items);
            Table.ItemsSource = ViewModel.TableItems;
        }
    }
}
