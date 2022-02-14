using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Utilities;

namespace AntiquesShop.Database.Models
{
    internal class Order : BaseNotifyPropertyChanged
    {
        private int _id;
        private DateTime _dateStart;
        private DateTime _dateEnd;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        [Column(TypeName = "datetime2")]
        public DateTime DateStart
        {
            get => _dateStart;
            set => Set(ref _dateStart, value);
        }

        [Column(TypeName = "datetime2")]
        public DateTime DateEnd
        {
            get => _dateEnd;
            set => Set(ref _dateEnd, value);
        }

        public Client Client { get; set; }
        public ICollection<Antiques> Antiques { get; set; }
    }
}
