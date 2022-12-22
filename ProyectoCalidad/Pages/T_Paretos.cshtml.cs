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

namespace ProyectoCalidad.Pages
{
    [AuthorizeForScopes(ScopeKeySection = "MicrosoftGraph:Scopes")]
    public class T_ParetosModel : PageModel
    {
        private readonly GraphServiceClient _graphServiceClient;
        private readonly ProyectoCalidad.Data.ProyectoCalidadContext _context;
        public T_ParetosModel(ProyectoCalidad.Data.ProyectoCalidadContext context, GraphServiceClient graphServiceClient)
        {
            _context = context;
            _graphServiceClient = graphServiceClient; ;
        }
        public IList<EnrollmentDeteccionGroups> Formulario_Model { get; set; } = default!;
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
                                                             ReleaseDate = dateGroup.First().ReleaseDate,
                                                             Paretos = dateGroup.First().Pareto,
                                                             ParetCount = dateGroup.Count()
                                                         };
            if (!string.IsNullOrEmpty(SearchString.ToString()) && !string.IsNullOrEmpty(SearchString2.ToString()))
            {
                data = data.Where(s => s.ReleaseDate >= SearchString && s.ReleaseDate <= SearchString2);
            }
            Formulario_Model = await data.ToListAsync();
        }
    }
}
