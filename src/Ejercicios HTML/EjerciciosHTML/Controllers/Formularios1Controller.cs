﻿using EjerciciosHTML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjerciciosHTML.Controllers
{
    public class Formularios1Controller : Controller
    {
        // GET: Formularios1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Formulario1 form)
        {
            return View();
        }
    }
}