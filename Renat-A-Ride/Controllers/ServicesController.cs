using Renat_A_Ride.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Renat_A_Ride.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        RentARideEntitiesDB DB = new RentARideEntitiesDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HourlyService()
        {
            List<car> cars = DB.cars.Where(temp => temp.serviceType.Contains("Hourly Service")).ToList();
            return View(cars);
        }

        public ActionResult AirportTransfer()
        {
            List<car> cars = DB.cars.Where(temp => temp.serviceType.Contains("Airport Service")).ToList();
            return View(cars);
        }

        public ActionResult DailyService()
        {
            List<car> cars = DB.cars.Where(temp => temp.serviceType.Contains("Daily Service")).ToList();
            return View(cars);

        }
        public ActionResult Booking()
        {
            if (Session["userName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("UserRegistration", "User");
            }
        }

        [HttpPost]
        public ActionResult Booking(int carID, string pickup, string drop, string dateTime)
        {
            normalService ns = new normalService();
            ns.carID = carID;
            ns.dropAddress = drop;
            ns.pickupAddress = pickup;
            ns.dateAndTime = dateTime;

            int uID = Convert.ToInt32(Session["userID"].ToString());
            ns.userservID = uID;

            DB.normalServices.Add(ns);
            DB.SaveChanges();

            ViewBag.BookingSuccess = "Booking Successful.";
            return Json("Data Inserted Succesfully", JsonRequestBehavior.AllowGet);
        }

    }
}