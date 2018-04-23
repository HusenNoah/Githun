using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Pages
{
    public class CreatePersonModel : PageModel
    {
        Repository repository = new Repository();

        [BindProperty]
        public Persons Persons { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        [HttpPost]
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            repository.CreatePerson(Persons);
            return Page();
        }
    }
}