using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    // 9. Se agrega en UI.Desktop carpetas ApplicationController, Forms y ViewModel
    // 10. Se agrega la clase ClientViewModel con el siguiente código
    public class ClientViewModel
    {
        // Se copian atributos de Domain.Model.Entities Client.cs
        // Validaciones
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
    }
}
