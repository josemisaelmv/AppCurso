using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCurso.Models
{
    public class MarcaCLS
    {
        [Display(Name = "Id Marca")]
        public int iidmarca { get; set; }
        [Display(Name = "Nombre Marca")]
        [Required]
        [StringLength(100, ErrorMessage = "La Longitud Máxima es 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripción Marca")]
        [Required]
        [StringLength(200, ErrorMessage = "La Longitud Máxima es 200")]
        public string descripcion { get; set; }
        //En esta no pondre display por que no la mostrare
        public int bhabilitado { get; set; }


    }
}