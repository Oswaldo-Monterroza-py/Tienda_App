using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Provedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProvedorId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public float Contacto { get; set; }

        [Required]
        [MaxLength(100)]
        public string CorreoElectronico { get; set; }

    }
}
