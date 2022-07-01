using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itea_Core_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookshelfController : ControllerBase
    {
        private static List<Bookshelf> Bookshelf { get; set; }

        static BookshelfController() 
        {
            Bookshelf = new List<Bookshelf>();
        }

        private readonly ILogger<BookshelfController> _logger;

        public BookshelfController(ILogger<BookshelfController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Create (Bookshelf books)
        {
            Bookshelf.Add(books);
        }

        [HttpPut("{id}")]
        public void Update(int id, Bookshelf books)
        {
            Bookshelf[id] = books;
        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            Bookshelf.Remove(Bookshelf[id]);
        }

        [HttpGet]
        public IEnumerable<Bookshelf> Get()
        {
            return Bookshelf;
        }

        [HttpGet("{id}")]
        public Bookshelf GetByID(int id)
        {
            return Bookshelf[id];
        }
    }
}
