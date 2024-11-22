using DicasSustentaveisGS1.Data;
using DicasSustentaveisGS1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace DicasSustentaveisGS1.Pages
{
    public class FrasesPreferidasModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public FrasesPreferidasModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<FrasePreferida> FrasesPreferidas { get; set; }

        public async Task OnGetAsync()
        {
           
            FrasesPreferidas = await _context.FrasesPreferidas
                .Include(fp => fp.Frase) 
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostExcluirAsync(int id)
        {
           
            var frasePreferida = await _context.FrasesPreferidas.FindAsync(id);

            if (frasePreferida != null)
            {
                _context.FrasesPreferidas.Remove(frasePreferida);
                await _context.SaveChangesAsync();

               
                TempData["Mensagem"] = "Frase preferida removida com sucesso!";
            }

            return RedirectToPage();
        }
    }
}
