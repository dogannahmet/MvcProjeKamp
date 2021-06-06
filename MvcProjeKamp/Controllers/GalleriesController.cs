using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class GalleriesController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());
        
        public ActionResult Index()
        {
            var files = imageFileManager.GetList();
            return View(files);
        }
    }
}