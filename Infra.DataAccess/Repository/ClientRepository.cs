using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se hace referencia a Domain.Abstractions y a Domain.Entities
using Domain.Model.Abstractions;
using Domain.Model.Entities;

namespace Infra.DataAccess.Repository
{
    // 7.
    public class ClientRepository : ConnectionSQL, IClientRepository// Hereda de ConnectionSQL, e implementa la interfaz IClientRepository que tiene CRUD
    {
        // Nota: Se debe cumplir contrato de la Interfaz, es decir, implementar sus atributos / metodos
        public int add(Client client)
        {
            throw new NotImplementedException();
        }

        public int edit(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients(string filter)
        {
            //throw new NotImplementedException();
            // Copio codigo de ClienteDao de patron MVC
            //  Esta clase sólo contiene métodos crud


            // METODOS CRUD
            SqlDataReader LeerFilas; // Lee filas de tablas
            SqlCommand Comando = new SqlCommand(); // Para ejecutar sp o t-sql
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros"; // Igual al SP de la DB
            Comando.CommandType = CommandType.StoredProcedure;
            //Comando.Parameters.AddWithValue("@Condicion", Condicion); // Parametro con el mismo valor de variable en sp. Se envia como parametro el metodo condicion 
            Comando.Parameters.AddWithValue("@Condicion", filter);
            Conexion.Open();

            LeerFilas = Comando.ExecuteReader(); // Para ller filas de tablas
            List<Client> ListaGenerica = new List<Client>();
            /*
             * Para obtener datos se puede:
             * -List
             * -Diccionario
             * -Serialización
             */

            // While: Mientras se leen filas, ir agregando registros a ListaGenerica
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Client
                {
                    // Se asignan valores a los atributos de ClientesDTO
                    ID = LeerFilas.GetInt32(0), // Se envía como parametro el número de columna de la db que tiene el id (empezando desde 0)
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

            public int remove(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
