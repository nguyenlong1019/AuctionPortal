using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalogue(int catalogueId)
        {
            ViewBag.CatalogueId = catalogueId;

            return View();
        }

        public ActionResult Lot(int catalogueId, int lotNo)
        {
            ViewBag.CatalogueId = catalogueId;
            ViewBag.lotNo = lotNo;

            return View();
        }
    }
}