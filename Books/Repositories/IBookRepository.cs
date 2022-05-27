using Books.Models;
namespace Books.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAll();
        public Task<BookModel> GetById(int id);
        public Task Insert(BookModel model);
        public Task Update(BookModel model);
        public Task Delete(int id);
    }
}
