using ClassLibrary.Abstract;
using ClassLibrary.Entities;
using System.Collections.Generic;

namespace ClassLibrary.Concrete
{
    public class EFBookRepository: IBookRepository
    {
        EFDbContext context = new EFDbContext();
        // only get data from database
        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }

    }
}
