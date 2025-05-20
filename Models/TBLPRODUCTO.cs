using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PRACTICA_AEAE_3.Models
{
    public class TBLPRODUCTO
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string strNombre { get; set; }

        [Display(Name = "Descripción")]
        public string strDescripcion { get; set; }

        [Range(1, 100000, ErrorMessage = "El precio debe ser mayor a 0")]
        [Display(Name = "Precio")]
        public decimal NumPrecio { get; set; }

        [Display(Name = "Stock")]
        public int NumStock { get; set; }

        // Relación con categorías (si existe)
        [Display(Name = "Categoría")]
        public int? IdCategoria { get; set; }
        public virtual TBLCATEGORIA TBLCATEGORIA { get; set; }
    }
}