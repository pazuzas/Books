using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }
    }
}
