using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")] //service this route when "See list of vendors" is clicked
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll(); //calling method in Models
      return View(allVendors); //will render name and description for each vendor
    }

   [HttpGet("/vendors/new")]  //service this route when "Add a new vendor" URL is clicked in landing page
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")] //form submission is serviced by this route
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index"); //redirect NOT to home but to "/vendors"
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id); //store object returned in type "Vendor"
      List<Order> vendorOrders = selectedVendor.Orders; //first find vendor and then get its orders
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }


    // This one creates new Orders within a given Vendor, not new Vendors:
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, string orderTitle, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, orderTitle, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}