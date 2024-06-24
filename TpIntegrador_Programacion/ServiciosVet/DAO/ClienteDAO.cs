using ServiciosVet.Models;
using System.Data;

namespace ServiciosVet.DAO
{
    internal class ClienteDAO
    {
        private VeterinariaDAO veterinariaDAO;

        public ClienteDAO()
        {
            veterinariaDAO = VeterinariaDAO.ObtenerInstancia();
        }

        public DataTable ObtenerClientes()
        {
            string query = " SELECT * FROM Clientes";
            return veterinariaDAO.ConsultarTabla(query);
        }

        public bool AgregarCliente(Cliente nuevoCliente)
        {
            string query = $"INSERT INTO Usuarios (DNI, Nombre) VALUES ('{nuevoCliente.DNI}', '{nuevoCliente.Nombre})'";
            return veterinariaDAO.EjecutarComando(query);
        }
    }
}
