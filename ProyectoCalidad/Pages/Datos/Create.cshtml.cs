using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoCalidad.Data;
using ProyectoCalidad.Models;
using Microsoft.Identity.Web;
using System.Net;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoCalidad.Pages.Datos
{
    //, Authorize(Roles = "Administrador")
    [AuthorizeForScopes(ScopeKeySection = "MicrosoftGraph:Scopes")]
    public class CreateModel : PageModel
    {
        private readonly ProyectoCalidad.Data.ProyectoCalidadContext _context;

        public CreateModel(ProyectoCalidad.Data.ProyectoCalidadContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Formulario_Model Formulario_Model { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Formulario_Model == null || Formulario_Model == null)
            {
                return Page();
            }

            _context.Formulario_Model.Add(Formulario_Model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}
