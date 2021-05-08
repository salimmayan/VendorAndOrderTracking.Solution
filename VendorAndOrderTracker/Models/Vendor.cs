using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
    public class Vendor
    {
      public string Name {get; set;}
      public string Description {get; set;}
      public List <Order> Orders {get; set;}
      public int Id {get;}
      public static List <Vendor> _instances = new List<Vendor> {};

      public Vendor (string vendorName, string description) {
        Name = vendorName;
        Description = description;
        Id = _instances.Count;
        Orders = new List<Order> {};
      }
    }
}