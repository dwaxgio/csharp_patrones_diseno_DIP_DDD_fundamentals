using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se hace referencia a Domain.model y a Infra.Access.Repository
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;


namespace Aplication
{
    // 8.
    public class ClientService
    {
        // Se declara Interfaz repositorio cliente
        readonly IClientRepository clientRepository; // Readonly, palabra reservada, en donde mecanismo de proteccion indica que la asignacion al campo solo puede ocurrir en el constructor de la misma clase
        public ClientService()
        {
            clientRepository = new ClientRepository();
        }

        public IEnumerable<Client> GetClientes(string filter)
        {
            return clientRepository.GetClients(filter); // Método de la Interfaz
        }
    }
}
