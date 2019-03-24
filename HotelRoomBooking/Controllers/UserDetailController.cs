using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelRoomBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelRoomBooking.Controllers
{
    public class UserDetailController : Controller
    {
        HotelRoomBookingDbContext context;

        public UserDetailController(HotelRoomBookingDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var userDetail = context.UserDetails.ToList();
            return View(userDetail);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserDetail e1)
        {
            context.UserDetails.Add(e1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Details(int id)
        {
            UserDetail userDetail = context.UserDetails.Where(x => x.UserId == id).SingleOrDefault();
            return View(userDetail);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            UserDetail userDetail = context.UserDetails.Find(id);

            return View(userDetail);
        }

        [HttpPost]
        public ActionResult Delete(int id, UserDetail e1)
        {
            var userDetail = context.UserDetails.Where(x => x.UserId == id).SingleOrDefault();
            context.UserDetails.Remove(userDetail);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserDetail userDetail = context.UserDetails.Where(x => x.UserId == id).SingleOrDefault();
            return View(userDetail);
        }

        [HttpPost]
        public ActionResult Edit(int id, UserDetail e1)
        {
            UserDetail userDetail = context.UserDetails.Where(x => x.UserId == id).SingleOrDefault();
            context.Entry(userDetail).CurrentValues.SetValues(e1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}