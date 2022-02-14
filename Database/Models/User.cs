using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Database.Models.Enums;
using AntiquesShop.Utilities;

namespace AntiquesShop.Database.Models
{
    internal class User : BaseNotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private Role _role;

        [ForeignKey(nameof(Models.RegistrationData))]
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

        public Role Role
        {
            get => _role;
            set => Set(ref _role, value);
        }

        public RegistrationData RegistrationData { get; set; }
    }
}
