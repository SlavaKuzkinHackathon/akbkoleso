using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace akbkoleso.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int RetailPrice { get; set; }
        public int InQuantity { get; set; }
        public List<CartItem> CartItems { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public string ImagePath { get; set; }

        public Product()
        {
            CartItems = new List<CartItem>();
            OrderItems = new List<OrderItem>();
        }
    }
}