using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    public class Registro_Empleado
    {
        public int Id { get; set; }
        public ICollection<Empleado> Tabla_Empleado { get; set; }
        public TimeSpan Hora_Entrada { get; set; }
        public TimeSpan Hora_Salida { get; set; }
    }
}