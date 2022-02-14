using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Database.Models.Base;

namespace AntiquesShop.Database.Models
{
    internal class RegistrationData : BaseModel
    {
        private int _id;
        private string _login;
        private string _hashedPassword;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        public string Login
        {
            get => _login;
            set => Set(ref _login, value);
        }

        public string HashedPassword
        {
            get => _hashedPassword;
            set => Set(ref _hashedPassword, value);
        }

        public User User { get; set; }
    }
}
