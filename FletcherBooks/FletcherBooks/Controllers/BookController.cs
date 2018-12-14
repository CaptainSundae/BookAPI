using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FletcherBooks.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FletcherBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : Controller
    {
        public List<Book> bookList = new List<Book>();
        
        public void setList()
        {
            bookList.Add(new Book() { Id = 1, Title = "Lord of the Rings", isbn10 = "9780544003415", isbn13 = "978-0544003415" });
            bookList.Add(new Book() { Id = 2, Title = "The Hobbit", isbn10 = "054792822X", isbn13 = "978-0547928227" });
        }
        // GET: api/<controller>
        [HttpGet]

        public List<Book> Get()
        {
            setList();
            return bookList;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            setList();
            for(int x=0; x<id && x<bookList.Count; x++)
            {
                if(bookList[x].Id == id)
                {
                    return bookList[x];
                }
            }

            return new Book();
        }

    }
}
