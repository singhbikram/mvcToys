using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WingtipToys.Models;

namespace WingtipToys.Controllers
{
    public class Categories : Controller
    {
        //B:
        private ProductContext  context = new ProductContext();
        // GET: Categories
        //public ActionResult Index() // Original line
        public ViewResult Index()        
        {
            return View(context.Categories.ToList());
        }
    }
}