using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea4Final.Controllers
{
    public class contenidoController : Controller
    {
        // GET: contenido
        public ActionResult index()
        {
            return View();
        }

        public ActionResult noticias()
        {
            return View();
        }

        public ActionResult musica()
        {
            return View();
        }

        public ActionResult peliculas()
        {
            return View();
        }
    }
}