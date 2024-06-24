using ServiciosVet.Models;
using System.Data;

namespace ServiciosVet.DAO
{
    internal class EspecieDAO
    {
        private VeterinariaDAO veterinariaDAO;

        public EspecieDAO()
        {
            veterinariaDAO = VeterinariaDAO.ObtenerInstancia();
        }

        public DataTable ObtenerEspecies()
        {
            string query = " SELECT * FROM Especies";
            return veterinariaDAO.ConsultarTabla(query);
        }

        ////public bool AgregarEspecie(Especie nuevaEspecie)
        ////{
        ////    string query = $"INSERT INTO Especie (Nombre, EdadMadurez, PesoPromedio) " +
        ////        $"VALUES ('{nuevaEspecie.Nombre}', {nuevaEspecie.EdadMadurez}, {nuevaEspecie.PesoPromedio})";
        ////    return this.EjecutarComando(query);
        ////}
        ///
        public void AgregarEspecie(Especie nuevoEspecie)
        {
            string query = $"INSERT INTO Especies (Nombre) VALUES ({nuevoEspecie.Nombre}";
            veterinariaDAO.EjecutarComando(query);
        }
    }
}
