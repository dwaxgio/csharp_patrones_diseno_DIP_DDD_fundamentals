using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se hace referencia a Domain,a Aplication y a ui.ViewModel
using Domain.Model.Entities;
using Aplication;
using UI.Desktop.ViewModel;

namespace UI.Desktop.ApplicationController
{
    // 11.
    class ClientController
    {
        public IEnumerable<ClientViewModel> GetClientsAll(string filter)
        {
            var clientList = new ClientService().GetClientes(filter);
            // Proceso de mapeado de datos
            List<ClientViewModel> viewModel = new List<ClientViewModel>();

            // Se recorre la entidad cliente en el resultado de Vista Cliente
            foreach (Client item in clientList)
            {
                viewModel.Add(new ClientViewModel
                {
                    ID = item.ID,
                    Nombre = item.Nombre,
                    Apellido = item.Apellido,
                    Direccion = item.Direccion,
                    Ciudad = item.Ciudad,
                    Email = item.Email,
                    Telefono = item.Telefono,
                    Ocupacion = item.Ocupacion
                });
            }
            return viewModel;
        }
    }
}
