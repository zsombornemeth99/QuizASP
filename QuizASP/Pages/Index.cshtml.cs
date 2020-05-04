using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizASP.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<quiz> Kerdesek { get; set; }

        public async Task OnGet()
        {
            Kerdesek = await _db.Quiz.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var kerdes = await _db.Quiz.FindAsync(id);
            if (kerdes == null)
            {
                return NotFound();
            }

            _db.Quiz.Remove(kerdes);

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        public void OnPost()
        {
            
        }
    }
}
