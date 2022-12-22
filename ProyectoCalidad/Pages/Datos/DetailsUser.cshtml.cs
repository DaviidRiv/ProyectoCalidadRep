using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoCalidad.Data;
using ProyectoCalidad.Models;
using Microsoft.AspNetCore.Authorization;

namespace ProyectoCalidad.Pages.Datos
{
    [Authorize(Roles = "Usuario")]
    public class DetailsUserModel : PageModel
    {
        private readonly ProyectoCalidad.Data.ProyectoCalidadContext _context;

        public DetailsUserModel(ProyectoCalidad.Data.ProyectoCalidadContext context)
        {
            _context = context;
        }

        public Formulario_Model Formulario_Model { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Formulario_Model == null)
            {
                return NotFound();
            }

            var formulario_model = await _context.Formulario_Model.FirstOrDefaultAsync(m => m.ID_Form == id);
            if (formulario_model == null)
            {
                return NotFound();
            }
            else
            {
                Formulario_Model = formulario_model;
            }
            return Page();
        }
    }
}
