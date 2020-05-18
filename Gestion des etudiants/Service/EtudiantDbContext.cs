using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    public class EtudiantDbContext:DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Filiere> Filieres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Server=YURI205B\\SQLEXPRESS;Database=GestionEtudiants;Trusted_Connection=True;");
        }

    }
}
