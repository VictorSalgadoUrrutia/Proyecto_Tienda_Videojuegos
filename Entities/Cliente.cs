﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Entities
{
   public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
