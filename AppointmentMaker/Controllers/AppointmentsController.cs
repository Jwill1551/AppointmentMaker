using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker.Controllers
{
    public class AppointmentsController : Controller
    {
        // GET: Appointment
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAppointmentDetails()
        {
            return View();
        }
    }
}
