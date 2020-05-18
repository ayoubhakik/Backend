using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    public class EtudiantServiceImpl: IEtudiantService
{
        public EtudiantDbContext dbContext = new EtudiantDbContext();

        
        public void Delete(int id)
        {
            dbContext.Etudiants.Remove(dbContext.Etudiants.Find(id));
            dbContext.SaveChanges();
        }

        public IEnumerable<Etudiant> EtudiantsParMotCle(string mot)
        {
            IEnumerable<Etudiant> etuds = dbContext.Etudiants.Where(e => e.nom.Contains(mot)).Include(e => e.filiere).ToList();
            return etuds;
        }

        public IEnumerable<Etudiant> FindAll()
        {
            return dbContext.Etudiants.Include(e => e.filiere).ToList();
        }

        

        public Etudiant Save(Etudiant e)
        {

            dbContext.Etudiants.Add(e);
            dbContext.SaveChanges();
            return e;
        }

        
    }

}
