using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;
 
namespace Hackaton.App.Frontend.Pages
{ 

    public class ListEntidadModel: PageModel
    {
        [BindProperty]
        public Entidades entidad {get;set;}
        private readonly RepositorioEntidades repositorioEntidades;
        public IEnumerable<Entidades> Entidades {get;set;}
 
        public ListEntidadModel(RepositorioEntidades repositorioEntidades)
        {
        this.repositorioEntidades=repositorioEntidades;
        }
 
        public void OnGet()
        {
        Entidades=repositorioEntidades.GetAll();
        }

        public IActionResult OnPost()
        {
            if(entidad.id>0)
            {
             repositorioEntidades.Delete(entidad.id);
            }

            return RedirectToPage("./List");

        }
    }
}