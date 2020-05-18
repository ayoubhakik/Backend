using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    public class FiliereServiceImpl : IFiliereService
    {
        public EtudiantDbContext dbContext = new EtudiantDbContext();

        public IEnumerable<Filiere> FindAll()
        {
            return dbContext.Filieres.ToList();
        }

       
    }
}
