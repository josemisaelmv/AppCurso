using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCurso.Models
{
    public class SucursalCLS
    {
        [Display(Name ="Id Sucursal")]
        public int iidsucursal{ get; set; }
        [Display(Name ="Nombre Sucursal")]
        [StringLength(100,ErrorMessage ="Longitud Maxima 100")]
        [Required]
        public string nombre { get; set; }
        [Display(Name ="Direccion Sucursal")]
        [StringLength(200,ErrorMessage ="Longitud Maxima 200")]
        [Required]
        public string direccion { get; set; }
        [Display(Name ="Telefono Sucursal")]
        [StringLength(10,ErrorMessage ="Longitud Maxima 10")]
        public string telefono { get; set; }
        [Display(Name ="Email Sucursal")]
        [StringLength(100,ErrorMessage ="Longitud Maxima 100")]
        [EmailAddress(ErrorMessage ="Ingresa un email valido")]
        public string email { get; set; }
        [Display(Name = "Fecha Apertura")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [Required]
        public DateTime fechaApertura { get; set; }
        public int bhabilitado { get; set; }

    }
}