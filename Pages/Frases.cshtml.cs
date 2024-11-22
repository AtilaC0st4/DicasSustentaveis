using DicasSustentaveisGS1.Data;
using DicasSustentaveisGS1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DicasSustentaveisGS1.Pages
{
    public class FrasesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public FrasesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Frase FraseAleatoria { get; set; }

       
        public void OnGet()
        {
            var frases = _context.Frases.ToList(); 

            if (frases.Any())
            {
                
                var random = new Random();
                int randomIndex = random.Next(frases.Count);

               
                FraseAleatoria = frases[randomIndex];
            }
            else
            {
              
                FraseAleatoria = null;
            }
        }



        public IActionResult OnPostSalvar(int id)
        {
            
            var frase = _context.Frases.Find(id);
            if (frase != null)
            {
                
                var frasePreferida = new FrasePreferida
                {
                    FraseId = id,

                };

               
                _context.FrasesPreferidas.Add(frasePreferida);
                _context.SaveChanges();

               
                TempData["Mensagem"] = "Frase salva como preferida!";
            }

            return RedirectToPage();
        }

    }
}
