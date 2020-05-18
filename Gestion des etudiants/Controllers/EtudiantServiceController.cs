using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GestionDesEtudiants.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionDesEtudiants.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EtudiantServiceController : Controller
    {
        private readonly IFiliereService filiereService;
        private readonly IEtudiantService etudiantService;
        public EtudiantServiceController(IEtudiantService e, IFiliereService f)
        {
            this.filiereService = f;
            this.etudiantService = e;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Etudiant> GetAllStudents()
        {
            return  etudiantService.FindAll();
            
        }

        // GET api/<controller>/5
        [HttpGet("{motCle}")]
        public IEnumerable<Etudiant>  GetByMotCle(string motCle)
        {

            return etudiantService.EtudiantsParMotCle(motCle);
        }

        // POST api/<controller>
        [HttpPost]
        public void Save(Etudiant etudiant)
        {
            etudiantService.Save(etudiant);
        }
        
      

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            etudiantService.Delete(id);
        }
    }
}
