﻿using System;
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
        [StringLength(100, ErrorMessage ="Longitud maxima 100")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        [StringLength(150, ErrorMessage = "Longitud maxima 150")]
        public string appaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        [StringLength(150, ErrorMessage = "Longitud maxima 150")]
        public string apmaterno { get; set; }
        [Display(Name = "Email Cliente")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido")]
        public string email { get; set; }
        [Display(Name ="Direccion")]
        [Required]
        public string direccion { get; set; }
        [Display(Name ="Sexo")]
        [Required]
        public int iidsexo { get; set; }
        [Display(Name = "Telefono Fijo")]
        [Required]
        [StringLength(10,ErrorMessage = "Longitud maxima 10")]
        public string telefonofijo { get; set; }
        [Display(Name = "Telefono Celular")]
        [Required]
        [StringLength(10, ErrorMessage = "Longitud maxima 10")]
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }
        public int btieneusuario { get; set; }
        public char tipousuario { get; set; }
    }
}