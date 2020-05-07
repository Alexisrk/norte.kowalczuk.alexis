using EjerciciosHTML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjerciciosHTML.Controllers
{
	public class HTMLController : Controller
	{
		// GET: HTML
		public ActionResult Index()
		{
			return View();
		}


		public ActionResult ConceptosBasicos1()
		{
			return View();
		}

		public ActionResult ConceptosBasicos2()
		{
			return View();
		}

		public ActionResult ConceptosBasicos3()
		{
			return View();
		}

		public ActionResult Enlaces()
		{
			return View();
		}

		public ActionResult Listas()
		{
			return View();
		}

		public ActionResult Tablas1()
		{
			return View();
		}

		public ActionResult Tablas2()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Formularios1(Formulario1 form)
		{
			return View();
		}

		[HttpGet]
		public ActionResult Formularios2(Formulario2 form)
		{
			return View();
		}

		[HttpGet]
		public ActionResult FormulariosHTML5(FormularioHTML5 form)
		{
			return View();
		}
	}
}