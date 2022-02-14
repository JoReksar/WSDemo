using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AntiquesShop.Database;
using AntiquesShop.Database.Models;
using AntiquesShop.Database.Models.Enums;


namespace AntiquesShop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static AntiquesShopDatabase _db = AntiquesShopDatabase.Instance;

        public App()
        {
            var db = _db.Database;

            if (db.Exists()) 
                return;

            db.Create();
            FillDatabase();
        }

        private static void FillDatabase()
        {
            _db.Users.AddRange(GetFakeUsers());
            _db.Antiques.AddRange(GetFakeAntiques());
            _db.Clients.AddRange(GetFakeClients());
            _db.SaveChanges();

            _db.Orders.AddRange(GetFakeOrders());
            _db.SaveChanges();

        }

        private static List<User> GetFakeUsers()
        {
            var users = new List<User>
            {
                new()
                {
                    Name = "Sergey", Role = Role.Administrator,
                    RegistrationData = new RegistrationData {Login = "A1", HashedPassword = "A1"}
                },
                new()
                {
                    Name = "Viktor", Role = Role.Director,
                    RegistrationData = new RegistrationData {Login = "D2", HashedPassword = "D2"}
                },
                new()
                {
                    Name = "Vladimir", Role = Role.Manager,
                    RegistrationData = new RegistrationData { Login = "M3", HashedPassword = "M3"}
                }
            };

            return users;
        }

        private static List<Antiques> GetFakeAntiques()
        {
            var antiques = new List<Antiques>
            {
                new()
                {
                    Name = "Стол 40-x", Category = Category.Furniture, Description = "Этот стол пережил очень много событий", Price = 500000m
                },
                new()
                {
                    Name = "Телевизор 70-х", Category = Category.Furniture, Description = "Телевизор из СССР", Price = 200000m
                },
                new()
                {
                    Name = "Портрет Петра I", Category = Category.Picture, Description = "Изображение Петра I", Price = 430000m
                },
                new()
                {
                    Name = "Кружка Леонардо да Винчи", Category = Category.Kitchenware, Description = "Старая кружка, принадлежавшая Леонардо да Винчи", Price = 733000m
                },
                new()
                {
                    Name = "Колье Екатерины II", Category = Category.Jewelry, Description = "Необычайно красивое колье, принадлежавшее Екатерине II", Price = 455000m
                }
            };

            return antiques;
        }
        private static List<Client> GetFakeClients()
        {
            var clients = new List<Client>
            {
                new()
                {
                    Name = "Natalya Morskaya Pehota", Phone = "+7 (911) 766-30-99", Address = "Moscow, Morozova st., 16"
                },
                new()
                {
                    Name = "Kokin Nikita Vladimirovich", Phone = "+7 (912) 450-33-24", Address = "Saint-Petersburg, Engelsa pr., 129"
                },
                new()
                {
                    Name = "Vyacheslav Krestovskii Andreevich", Phone = "+7 (912) 655-98-34", Address = "Kirishi, Kirieshki st., 44"
                }
            };

            return clients;
        }

        private static List<Order> GetFakeOrders()
        {
            var clients = _db.Clients.ToList();
            var antiques = _db.Antiques.ToList();

            var orders = new List<Order>
            {
                new()
                {
                    DateStart = DateTime.Now.Add(TimeSpan.FromDays(-1)), DateEnd = DateTime.Now.Add(TimeSpan.FromDays(3)), Client = clients[0], Antiques = new List<Antiques> { antiques[0], antiques[2] }
                },
                new()
                {
                    DateStart = DateTime.Now, DateEnd = DateTime.Now.Add(TimeSpan.FromDays(3)), Client = clients[0], Antiques = new List<Antiques> { antiques[0], antiques[1] }
                },
                new()
                {
                    DateStart = DateTime.Now.Add(TimeSpan.FromDays(2)), DateEnd = DateTime.Now.Add(TimeSpan.FromDays(6)), Client = clients[2], Antiques = new List<Antiques> { antiques[0], antiques[1], antiques[3] }
                },
                new()
                {
                    DateStart = DateTime.Now, DateEnd = DateTime.Now.Add(TimeSpan.FromDays(1)), Client = clients[1], Antiques = new List<Antiques> { antiques[4] }
                },
                new()
                {
                    DateStart = DateTime.Now.Add(TimeSpan.FromDays(3)), DateEnd = DateTime.Now.Add(TimeSpan.FromDays(6)), Client = clients[2], Antiques = new List<Antiques> { antiques[1] }
                },
            };

            return orders;
        }


    }
}
