using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Graph;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Newtonsoft.Json;
using ProyectoCalidad.Models;
using System.Data;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ProyectoCalidad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCalidad.Pages
{
    [AuthorizeForScopes(ScopeKeySection = "MicrosoftGraph:Scopes")]
    public class T_DeteccionModel : PageModel
    {
        
        private readonly GraphServiceClient _graphServiceClient;
        public readonly ProyectoCalidad.Data.ProyectoCalidadContext _context;
        public T_DeteccionModel(ProyectoCalidad.Data.ProyectoCalidadContext context, GraphServiceClient graphServiceClient)
        {
            _context = context;
            _graphServiceClient = graphServiceClient; ;
        }
        public IList<EnrollmentDeteccionGroups> Formulario_Model { get; set; } = default!;
        public IList<Formulario_Model> Formulario_Model2 { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public DateTime? SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public DateTime? SearchString2 { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDeteccionGroups> data = from d in _context.Formulario_Model
                                                         group d by new
                                                         {                                           
                                                             d.ReleaseDate,
                                                             d.Deteccion
                                                         }
                                                         into dateGroup
                                                         select new EnrollmentDeteccionGroups()
                                                         {
                                                             //ReleaseDate = dateGroup.ReleaseDate.Key()
                                                             ReleaseDate = dateGroup.First().ReleaseDate,
                                                             Deteccion = dateGroup.First().Deteccion,
                                                             DetCount = dateGroup.Count()
                                                         };

            if (!string.IsNullOrEmpty(SearchString.ToString()) && !string.IsNullOrEmpty(SearchString2.ToString()))
            {
                data = data.Where(s => s.ReleaseDate >= SearchString && s.ReleaseDate <= SearchString2);
            }
            Formulario_Model = await data.ToListAsync();
        }
    }
}
