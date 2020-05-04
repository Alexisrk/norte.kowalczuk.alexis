using EjerciciosHTML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjerciciosHTML.Controllers
{
    public class Formularios2Controller : Controller
    {
        // GET: Formularios2
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(Formulario2 form)
        {
            return View();
        }
    }
}