using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCurso.Models
{
    public class ClienteCLS
    {
        [Display(Name ="Id Cliente")]
        public int iidcliente { get; set; }
        [Display(Name ="Nombre")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        public string appaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        public string apmaterno { get; set; }
        [Display(Name = "Email Cliente")]
        [Required]
        public string email { get; set; }
        [Display(Name ="Direccion")]
        [Required]
        public string direccion { get; set; }
        [Display(Name ="Sexo")]
        [Required]
        public int iidsexo { get; set; }
        [Display(Name = "Telefono Fijo")]
        [Required]
        public string telefonofijo { get; set; }
        [Display(Name = "Telefono Celular")]
        [Required]
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }
        public int btieneusuario { get; set; }
        public char tipousuario { get; set; }
    }
}