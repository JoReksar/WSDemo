using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Database.Models.Base;
using AntiquesShop.Database.Models.Enums;

namespace AntiquesShop.Database.Models
{
    internal class Antiques : BaseModel
    {
        private int _id;
        private string _name;
        private decimal _price;
        private Category _category;
        private string? _description;

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

        public decimal Price
        {
            get => _price;
            set => Set(ref _price, value);
        }

        public Category Category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        public string? Description
        {
            get => _description;
            set => Set(ref _description, value);
        }
    }
}
