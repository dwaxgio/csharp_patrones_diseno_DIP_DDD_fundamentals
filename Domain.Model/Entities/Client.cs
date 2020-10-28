using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    // 1. Agregar carpetas de soluciones 1,2,3,4 y más de ser requerido
    // 2. Agregar los proyectos correspondientes a cada una de las carpetas de soluciones
    // 3. Agregar referencias acorde al patron de diseño DIP+DDD
    // 4. Agregar en Entities, la clase Client con lo siguiente:
    public class Client
    {
        // ATRIBUTOS
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        // ... + atributos si se requieren, recordar encapsulación

        // COMPORTAMIENTOS / REGLAS EMPRESARIALES

    }
}
