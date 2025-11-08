using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDBContext context;

        public BooksController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        //Retrieve all books from the database asynchronously
        public async Task<IActionResult> Index() 
        {
            var books = await context.Books.ToListAsync();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Security features 
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "Books"); //prevent the duplicate
            }
            return View(book);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // Find the book by its primary key (id) asynchronously
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //For Edit the book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "Books");
            }
            return View(book);
        }

        //For Details
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        //For Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")] // Responds to POST but uses "Delete"
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            context.Books.Remove(book);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Books");
        }

    }
}
