using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    [Table("Estado_Empleado")]
    public class Estado_Empleado
    {
        public int Id { get; set; }
        public string Estado { get; set; }
    }
}