using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.Repositories
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public SQLBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            BookModel book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BookModel>> GetAll()
        {
            List<BookModel> list = await _context.Books.ToListAsync();
            return list;
        }

        public async Task<BookModel> GetById(int id)
        {
            BookModel book = await _context.Books.FindAsync(id);
            return book;
        }

        public async Task Insert(BookModel model)
        {
            _context.Books.Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BookModel model)
        {
            _context.Books.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
