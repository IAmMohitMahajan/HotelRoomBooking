using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelRoomBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelRoomBooking.Controllers
{
    public class CustomerController : Controller
    {
        HotelRoomBookingDbContext context;

        public CustomerController(HotelRoomBookingDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer e1)
        {
            context.Customers.Add(e1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            Customer customer = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return View(customer);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            Customer customer = context.Customers.Find(id);

            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(int id, Customer e1)
        {
            var customer = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer customer = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(int id , Customer e1)
        {
            Customer customer = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            context.Entry(customer).CurrentValues.SetValues(e1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}