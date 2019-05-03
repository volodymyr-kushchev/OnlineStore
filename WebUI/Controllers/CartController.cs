using ClassLibrary.Abstract;
using ClassLibrary.Concrete;
using ClassLibrary.Entities;
using WebUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CartController : Controller
    {
        private IBookRepository repository;


        public CartController()
        {
            repository = new EFBookRepository();
        }

        public ViewResult Index(Cart cart)
        {
            return View(
                new CartIndexViewModel { Cart = cart }
                );
        }

        public RedirectToRouteResult AddToCart(Cart cart, int bookId)
        {
            Book book = repository.Books
                .FirstOrDefault(b => b.BookId == bookId);

            if (book != null)
            {
                cart.AddItem(book, 1);
            }

            return RedirectToAction("List","Books", new { genre = book.Genre});
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int bookId)
        {
            Book book = repository.Books
                .FirstOrDefault(b => b.BookId == bookId);

            if (book != null)
            {
                cart.RemoveLine(book);
            }

            return RedirectToAction("Index");
        }

    }
}