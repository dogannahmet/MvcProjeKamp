using DataAccesLayer.Concrete;
using System.Linq;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        public ActionResult StatisticsBox()
        {

            ViewBag.countOfCategories = context.Categories.Count();

            ViewBag.countOfHeadingSoftwareCategory = context.Headings.Count(h => h.Category.CategoryName == "Yazılım");

            ViewBag.countOfWriterLetterAInWriterName = context.Writers.Count(w => w.WriterName.Contains("a"));

            ViewBag.categoryNameWithMostHeading = context.Categories.Where(c => c.CategoryId == context.Headings.GroupBy(x => x.CategoryId).
            OrderByDescending(x => x.Count()).Select(x => x.Key).
            FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();

            var statusTrue = context.Categories.Count(c => c.CategoryStatus == true);
            var statusFalse = context.Categories.Count(c => c.CategoryStatus == false);
            ViewBag.categoryStatusTrueOrFalse = statusTrue - statusFalse;
           
            return View();

        }
    }
}