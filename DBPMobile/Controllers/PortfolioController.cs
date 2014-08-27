using DBPMobile.Models;
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

            return View(GetImages("Fashion"));
        }

        //
        // GET: /Portfolio/DenverFashionPhotographer
        public ActionResult FashionPhotographerInDenver()
        {
            return View();
        }

        public List<PortfolioImage> GetImages(string imageDirectory)
        {
            DirectoryInfo di = new DirectoryInfo(Server.MapPath(String.Format("~/Content/Portfolio/{0}", imageDirectory)));

            FileInfo[] rgFiles = di.GetFiles("*.jpg");
            List<FileInfo> files = rgFiles.ToList<FileInfo>();

            List<PortfolioImage> images = new List<PortfolioImage>();
            foreach (FileInfo fi in files)
            {
                PortfolioImage image = new PortfolioImage() { ImageLocation = String.Format("/Content/Portfolio/{0}/{1}", imageDirectory, fi.Name) };
                images.Add(image);
            }
            return images;
        }
    }
}