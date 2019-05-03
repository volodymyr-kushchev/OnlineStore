using ClassLibrary.Entities;
using System.Data.Entity;

namespace ClassLibrary.Concrete
{
    class EFDbContext:DbContext
    {
        public EFDbContext() : base() { }
        public DbSet<Book> Books { set; get; }

    }
}
