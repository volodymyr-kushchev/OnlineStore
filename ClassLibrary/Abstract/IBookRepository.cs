using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.Abstract
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
    }
}
