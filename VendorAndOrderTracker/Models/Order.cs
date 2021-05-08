using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
    public class Order
    {
        public string Description { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
        public string Date { get; set; }
        public static List<Order> _instances = new List<Order> { };
        public int Id { get; }

        public Order(string description, string title, int price)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Title = title;
            Price = price;
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

    }
}