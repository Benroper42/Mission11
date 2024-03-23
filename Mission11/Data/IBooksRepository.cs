using Mission11.Models;

namespace Mission11.Data
{
    public interface IBooksRepository
    {
        public IQueryable<Book> Books { get; }
    }
}