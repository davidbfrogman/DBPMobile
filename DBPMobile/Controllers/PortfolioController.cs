using DBPMobile.Models;
using DBPMobile.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DBPMobile.Controllers
{
    public class PortfolioController : Controller
    {
        //
        // GET: /Portfolio/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Portfolio/DenverFashionPhotographer
        public ActionResult DenverFashionPhotographer()
        {
            return View(PortfolioImageUtility.GetImages("Fashion", this.Server, false));
        }

        //
        // GET: /Portfolio/DenverFashionPhotographer
        public ActionResult FashionPhotographerInDenver()
        {
            return View();
        }
    }
}