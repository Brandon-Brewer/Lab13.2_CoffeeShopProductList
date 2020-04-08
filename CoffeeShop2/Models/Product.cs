using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop2.Models
{
    public class Product
    {
        /*
          CREATE TABLE Products (
            Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
            Name nvarchar(50) NOT NULL,
            Price real NOT NULL,
            Description nvarchar(280),
            Category nvarchar(20) NOT NULL 
            );   
        */
        private int id;
        private string name;
        private double price;
        private string description;
        private string category;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
    }
}
