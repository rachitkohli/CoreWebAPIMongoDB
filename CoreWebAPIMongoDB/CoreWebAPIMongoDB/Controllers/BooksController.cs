using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPIMongoDB.Model;
using CoreWebAPIMongoDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPIMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly BookService _bookservice;
        public BooksController(BookService bookService)
        {
            _bookservice = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _bookservice.Get();
        }

        [HttpGet("{category}")]
        public ActionResult<List<Book>> Get(string category)
        {
            return _bookservice.Get(category);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}