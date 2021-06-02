using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class MessagesController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        
        public ActionResult Inbox()
        {
            var messageBox = messageManager.GetListInbox();
            return View(messageBox);
        }

        public ActionResult Sendbox()
        {
            var messageBox = messageManager.GetListSendbox();
            return View(messageBox);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            return View();
        }
    }
}