using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroReal.Models{
    public class Persona
    {
        [Key] public int PersonaId { get; set; }

        [Required(ErrorMessage = "Debe poner un Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe poner un Telefono")]
        public string Telefono { get; set; }     

        [Required(ErrorMessage = "Debe poner un Cedula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Debe poner una Direccion")]
        public string Direccion { get; set; }   

        [Required(ErrorMessage = "Debe poner una Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}