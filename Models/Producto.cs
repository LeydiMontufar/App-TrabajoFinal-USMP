using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_TrabajoFinal_USMP.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public Decimal PorcentajeDescuento { get; set; }

        public String ImageName { get; set; }

        public String EstadoProducto { get; set; }

        
    }
}