using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizASP.Model;

namespace QuizASP.Pages.Shared
{
    public class ModositModel : PageModel
    {
        private ApplicationDbContext _db;

        public ModositModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public quiz Modosit { get; set; }

        public async Task OnGet(int id)
        {
            Modosit = await _db.Quiz.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var kerdesFromDb = await _db.Quiz.FindAsync(Modosit.Kerdes_id);
                kerdesFromDb.Kerdes = Modosit.Kerdes;
                kerdesFromDb.Valasz_A = Modosit.Valasz_A;
                kerdesFromDb.Valasz_B = Modosit.Valasz_B;
                kerdesFromDb.Valasz_C = Modosit.Valasz_C;
                kerdesFromDb.Valasz_D = Modosit.Valasz_D;
                kerdesFromDb.Helyes = Modosit.Helyes;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}