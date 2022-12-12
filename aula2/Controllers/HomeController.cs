using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula.Controllers
{
    public class HomeController : Controller
    {
        //localhost:xxxx
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Sobre()
        {
            return View();
        }

    }
}