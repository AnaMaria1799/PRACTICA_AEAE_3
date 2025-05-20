using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PRACTICA_AEAE_3.Models
{
    public class TBLCLIENTES
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Nombre obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre")]
        public string strNombre { get; set; }

        [Required(ErrorMessage = "Documento obligatorio")]
        [Range(1000000, 9999999999, ErrorMessage = "Documento inválido")]
        [Display(Name = "Documento")]
        public long NumDocumento { get; set; }

        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        [Display(Name = "Dirección")]
        public string StrDireccion { get; set; }

        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Teléfono inválido")]
        [Display(Name = "Teléfono")]
        public string StrTelefono { get; set; }

        [EmailAddress(ErrorMessage = "Correo inválido")]
        [Display(Name = "Correo")]
        public string StrEmail { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Fecha de Registro")]
        public DateTime DtmFechaRegistro { get; set; } = DateTime.Now;
    }
}