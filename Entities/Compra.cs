using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Entities
{
     public class Compra
    {
        [Key] 
        public int IdCompra { get; set; }
        public string Detalles { get; set; }
        public double TotalCompra { get; set; }   
        public int Cantidad { get; set; }


        [ForeignKey("Vendedores")]
        public int IdVendedor { get; set; }
        public Vendedor Vendedores { get; set; }

        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }

        [ForeignKey("Productos")]
        public int IdProducto { get; set; }
        public Productos Productos { get; set; }






    }
}
