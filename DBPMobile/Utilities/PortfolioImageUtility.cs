using DBPMobile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DBPMobile.Utilities
{
    public static class PortfolioImageUtility
    {
        public static List<PortfolioImage> GetImages(string imageDirectory, HttpServerUtilityBase server, bool randomize)
        {
            DirectoryInfo di = new DirectoryInfo(server.MapPath(String.Format("~/Content/Portfolio/{0}", imageDirectory)));

            FileInfo[] rgFiles = di.GetFiles("*.jpg");
            List<FileInfo> files = rgFiles.ToList<FileInfo>();

            List<PortfolioImage> images = new List<PortfolioImage>();
            foreach (FileInfo fi in files)
            {
                PortfolioImage image = new PortfolioImage() { ImageLocation = String.Format("/Content/Portfolio/{0}/{1}", imageDirectory, fi.Name) };
                images.Add(image);
            }

            return randomize ? MixList<PortfolioImage>(images)  : images;
        }

        public static List<E> MixList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }
    }
}