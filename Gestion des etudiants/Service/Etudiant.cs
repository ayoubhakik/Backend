using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Service
{
    [Table("Etudiants")]
    public class Etudiant
    {
        [Key]
        [Display(Name="Id Etudiant")]
        public int id { get; set; }
        [Required]
        public string nom { get; set; }
        [Required]
        public string prenom { get; set; }

        [ForeignKey("id_filiere")]
        public int id_filiere { get; set; }

        public virtual Filiere filiere { get; set; }

        
    }
}
