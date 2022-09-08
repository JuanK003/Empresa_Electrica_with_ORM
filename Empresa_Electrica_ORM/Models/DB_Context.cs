using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    public class DB_Context
    {
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Estado_Empleado> Estado_Empleados { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Datos_Empleado> Datos_Empleados { get; set; }
        public DbSet<Registro_Empleado> Registro_Empleados { get; set; }
        public DbSet<Tareas_Empleado> Tareas_Empleados { get; set; }
    }
}