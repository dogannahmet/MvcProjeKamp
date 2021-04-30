using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            //var categoryValues = categoryManager.GetAllBL();
            return View();
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //categoryManager.CategoryAddBL(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}