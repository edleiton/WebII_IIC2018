using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idprofesor { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Primer apellido")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Apellido1 { get; set; }
        [Display(Name = "Segundo apellido")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Apellido2   { get; set; }
        public int? Estado { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }

}
