using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; } //Empty: Not created now-created from inside constructor
        public int Id { get; }
        private static List<Vendor> _instances = new List<Vendor> { };


        public Vendor(string vendorName, string description)
        {
            Name = vendorName;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}