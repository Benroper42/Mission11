using Mission11.Models;

namespace Mission11.Data
{
    public class EfBooksRepository : IBooksRepository
    {
        private BookstoreContext _context;

        public EfBooksRepository(BookstoreContext temp)
        {
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}