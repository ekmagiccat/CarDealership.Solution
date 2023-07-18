using Microsoft.AspNetCore.Mvc;
using CarDeal.Models;
using System.Collections.Generic;

namespace CarDeal.Controllers
{
    public class CarController : Controller
    {

        [HttpGet("/Cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string description)
        {
            Car myCar = new Car(description);
            return RedirectToAction("Index");
        }

    }
}