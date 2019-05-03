using ClassLibrary.Abstract;
using ClassLibrary.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private IBookRepository repository;

        public NavController()
        {
            repository = new EFBookRepository();
        }

        public PartialViewResult Categories(string genre = null)
        {
            ViewBag.SelectedGenre = genre;

            IEnumerable<string> genres = repository.Books
                .Select(book => book.Genre)
                .Distinct()
                .OrderBy(x => x);

            return PartialView("Categories", genres);
        }
    }
}