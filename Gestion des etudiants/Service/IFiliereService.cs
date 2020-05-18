using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    public interface IFiliereService
    {
         IEnumerable<Filiere> FindAll();
    }
}
