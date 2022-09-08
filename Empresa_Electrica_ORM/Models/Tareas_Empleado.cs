using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    public class Tareas_Empleado
    {
        public int Id { get; set; }
        public string Nombre_Tarea { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Empleado> Tabla_Empleado { get; set; }
    }
}