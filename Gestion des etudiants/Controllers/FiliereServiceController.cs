using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDesEtudiants.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionDesEtudiants.Controllers
{
    [Route("api/[controller]")]
    public class FiliereServiceController : Controller
    {
        private readonly IFiliereService filiereService;
        private readonly IEtudiantService etudiantService;

        public FiliereServiceController(IEtudiantService e, IFiliereService f)
        {
            this.filiereService = f;
            this.etudiantService = e;
        }
        // GET: api/<controller>
        
        [HttpGet]
        public IEnumerable<Filiere> Get()
        {
            return filiereService.FindAll();

        }

        
    }
}
