using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    public interface IEtudiantService
    {
        Etudiant Save(Etudiant e);
        IEnumerable<Etudiant> FindAll();
        IEnumerable<Etudiant> EtudiantsParMotCle(string mot);
        void Delete(int id);
    }
}
