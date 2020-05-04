using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizASP.Model;

namespace QuizASP.Pages
{
    public class LetrehozModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public LetrehozModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public quiz Uj { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Quiz.AddAsync(Uj);
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