using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idmateria { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "El nombre es requerido para agregar la materia")]
        [Display(Name = "Nombre de materia")]
        
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El estado es requerido para agregar la materia")]
        [Display(Name = "Estado de la materia")]
        public int? Estado { get; set; }
        public int? Precio { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
