using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Entities
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }   


    }
}
