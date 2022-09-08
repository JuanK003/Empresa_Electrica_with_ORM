using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    public class Datos_Empleado
    {
        public int Id { get; set; }
        public ICollection<Empleado> Tabla_Empleado { get; set; }
        public DateTime Fecha_Contratacion { get; set; }
        public float Salario { get; set; }
        public string Permisos { get; set; }
        public ICollection<Registro_Empleado> Tabla_Registro_Empleado { get; set; }
        public ICollection<Tareas_Empleado> Tabla_Tareas_Empleado { get; set; }
    }
}