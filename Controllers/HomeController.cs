using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TownsendPortfolio.Models;

namespace TownsendPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private ldtPortfolioEntities1 db = new ldtPortfolioEntities1();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }
    }
}