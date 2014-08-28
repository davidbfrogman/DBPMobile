using DBPMobile.Utilities;
using System.Web.Mvc;

namespace DBPMobile.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(PortfolioImageUtility.GetImages("Masonry", this.Server, true));
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}
