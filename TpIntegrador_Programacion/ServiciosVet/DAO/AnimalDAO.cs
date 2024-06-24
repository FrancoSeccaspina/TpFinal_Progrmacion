using ServiciosVet.Models;
using System.Data;

namespace ServiciosVet.DAO
{
    internal class AnimalDAO
    {
        private VeterinariaDAO veterinariaDAO;

        public AnimalDAO()
        {
            veterinariaDAO = VeterinariaDAO.ObtenerInstancia();
        }
        public DataTable ObtenerAnimales()
        {
            string query = " SELECT * FROM Animales";
            return veterinariaDAO.ConsultarTabla(query);
        }

        public bool AgregarAnimal(Animal nuevoAnimal)
        {
            string query = $"INSERT INTO Usuarios (Nombre, Peso, Edad, IDCliente, IDEspecie) " +
                $"VALUES ('{nuevoAnimal.Nombre}', {nuevoAnimal.Peso}, {nuevoAnimal.Edad}, {nuevoAnimal.IDCliente}, {nuevoAnimal.IDEspecie})";
            return veterinariaDAO.EjecutarComando(query);
        }

    }
}
