using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GestionAeroport.Pages
{
    public class AvionsModel : PageModel
    {
        private readonly ILogger<AvionsModel> _logger;
        private AvionDbContext _database;

        public IList<Avion> Avions { get; set; }

        public AvionsModel(ILogger<AvionsModel> logger, AvionDbContext database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult OnGet()
        {
            //Avions = _database.Avions.ToList();

            Avions = new List<Avion>();
            
            Avion av1 = new Avion(1, "DZ-507-EK", 300, 800, 1000, 100);
            Avion av2 = new Avion(2, "DZ-507-EK", 300, 800, 1000, 100);
            
            Avions.Add(av1);
            Avions.Add(av2);



            return Page();
        }
    }
}
