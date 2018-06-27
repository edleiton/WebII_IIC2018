using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Matricula
    {
        public int Idmatricula { get; set; }
        [Display(Name = "Alumno")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int? Idalumno { get; set; }
        [Display(Name = "Profesor")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int? Idprofesor { get; set; }
        [Display(Name = "Materia")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int? Idmateria { get; set; }
        public double? Nota { get; set; }

        public Alumno IdalumnoNavigation { get; set; }
        public Materia IdmateriaNavigation { get; set; }
        public Profesor IdprofesorNavigation { get; set; }
    }
}
