using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PRACTICA_AEAE_3.Models
{
    public class TBLCATEGORIA
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string strNombre { get; set; }

        public virtual ICollection<TBLPRODUCTO> TBLPRODUCTO { get; set; }
    }
}