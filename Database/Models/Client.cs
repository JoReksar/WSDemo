using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Database.Models.Base;

namespace AntiquesShop.Database.Models
{
    internal class Client : BaseModel
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _address;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string Phone
        {
            get => _phone;
            set => Set(ref _phone, value);
        }

        public string Address
        {
            get => _address;
            set => Set(ref _address, value);
        }

        public ICollection<Order>? Order { get; set; }
    }
}
