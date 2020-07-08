using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesBookCRUD.Model;

namespace RazorPagesBookCRUD.Pages.BookListPages
{
    public class EditModel : PageModel
    {
        //get an instance of the DB using ApplicationDbContext
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set;  }

        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {                
                var BookFromDb = await _db.Book.FindAsync(Book.ID);
                BookFromDb.ID = Book.ID;
                BookFromDb.name = Book.name;
                BookFromDb.Author = Book.Author;
                BookFromDb.ISBN = Book.ISBN;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }
    }
}