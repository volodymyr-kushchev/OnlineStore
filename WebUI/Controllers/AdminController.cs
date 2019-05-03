using ClassLibrary.Abstract;
using ClassLibrary.Concrete;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
    //doesn't work
    public class AdminController : Controller
    {
        private IBookRepository _repository;

        public AdminController()
        {
            _repository = new EFBookRepository();
        }

        //public JsonResult ShowBooks()
        //{
        //    return Json(_repository.Books, JsonRequestBehavior.AllowGet);
        //}
    }
}