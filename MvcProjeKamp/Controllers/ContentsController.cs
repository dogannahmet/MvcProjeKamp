using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class ContentsController : Controller
    {
        // GET: Contents

        ContentManager contentManager = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentValue = contentManager.GetListByHeadingId(id);

            return View(contentValue);
        }
    }
}