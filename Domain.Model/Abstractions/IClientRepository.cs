using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se referencian entidades del modelo
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface IClientRepository
    {
        // 5.
        // Comportamientos que va a tener la clase que la implemente
        // Ej, operaciones CRUD de entidad Cliente
        int add(Client client);
        int edit(Client client);
        int remove(Client client);
        IEnumerable<Client> GetClients(string filter); // Retorna colección de la base de datos
        // ...+
        
    }
}
