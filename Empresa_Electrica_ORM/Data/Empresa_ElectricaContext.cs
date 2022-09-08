using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Data
{
    public class Empresa_ElectricaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Empresa_ElectricaContext() : base("name=Empresa_ElectricaContext")
        {
        }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Estado_Empleado> Estado_Empleado { get; set; }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Puesto> Puestoes { get; set; }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Empleado> Empleadoes { get; set; }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Tareas_Empleado> Tareas_Empleado { get; set; }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Registro_Empleado> Registro_Empleado { get; set; }

        public System.Data.Entity.DbSet<Empresa_Electrica_ORM.Models.Datos_Empleado> Datos_Empleado { get; set; }
    }
}
