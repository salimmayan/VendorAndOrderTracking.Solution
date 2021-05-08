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
  }
}