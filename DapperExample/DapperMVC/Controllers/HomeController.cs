using Dapper;
using DapperMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace DapperMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
