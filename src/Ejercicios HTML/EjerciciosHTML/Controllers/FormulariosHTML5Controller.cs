using EjerciciosHTML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjerciciosHTML.Controllers
{
    public class FormulariosHTML5Controller : Controller
    {
        [HttpGet]
        public ActionResult Index(FormularioHTML5 form)
        {
            return View();
        }
    }
}