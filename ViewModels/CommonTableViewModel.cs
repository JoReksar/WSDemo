using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Utilities;

namespace AntiquesShop.ViewModels
{
    // Смысл от ViewModel?
    internal class CommonTableViewModel<T> : BaseNotifyPropertyChanged
    {
        private ObservableCollection<T> _tableItems;
        public ObservableCollection<T> TableItems
        {
            get => _tableItems;
            set => Set(ref _tableItems, value);
        }

        public CommonTableViewModel(IEnumerable<T> items)
        {
            TableItems = new ObservableCollection<T>(items);
        }
    }
}
