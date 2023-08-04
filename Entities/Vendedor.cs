using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Entities
{
    public class Vendedor
    {
        [Key]
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int IdRoles { get; set;}
        public Roles Roles { get; set; }


    }
}
