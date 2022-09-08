using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    [Table("Puesto")]
    public class Puesto
    {
        public int Id { get; set; } 
        public string Puesto_Empleado { get; set; }
    }
}