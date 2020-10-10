using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Bussiness.Cars;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Presentation.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;

        public CarController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View(this.carRepository.Cars);
        }
    }
}
