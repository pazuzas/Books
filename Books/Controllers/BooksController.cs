using Books.Models;
using Books.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BooksController> _logger;
        public BooksController(IBookRepository bookRepository, ILogger<BooksController> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }
        [HttpPost]
        [Route("/Books/Insert")]
        public async Task Insert(BookModel book)
        {
            await _bookRepository.Insert(book);
        }
        [HttpGet]
        [Route("/Books/GetAll")]
        public async Task<List<BookModel>> GetAll()
        {
            return await _bookRepository.GetAll();
        }
        [HttpGet]
        [Route("/Books/GetById/{id}")]
        public async Task<BookModel> GetById(int id)
        {
            return await _bookRepository.GetById(id);
        }
        [HttpPost]
        [Route("/Books/Update")]
        public async Task Update(BookModel book)
        {
            await _bookRepository.Update(book);
        }
        [HttpDelete]
        [Route("/Books/Delete/{id}")]
        public async Task Delete(int id)
        {
            await _bookRepository.Delete(id);
        }
    }
}
