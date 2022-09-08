using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Empresa_Electrica_ORM.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Telefono { get; set; }
        public ICollection<Puesto> Tabla_Puesto { get; set; }
        public string UserName { get; set; }
        public string Contraseña { get; set; }
        public ICollection<Estado_Empleado> Tabla_Estado_Empleado { get; set; }
        public string Direccion { get; set; }
        public string DPI { get; set; }
    }
}