﻿using ServiciosVet.Models;
using System.Data;


namespace ServiciosVet.DAO
{
    internal class UsuarioDao
    {
        private VeterinariaDAO veterinariaDAO;

        public UsuarioDao()
        {
            veterinariaDAO = VeterinariaDAO.ObtenerInstancia();
        }

        public DataTable ObtenerUsuarios()
        {
            string query = "SELECT * FROM Usuario";
            return veterinariaDAO.ConsultarTabla(query);
        }

        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            string query = $"INSERT INTO Usuarios (NickName, Contra) VALUES ('{nuevoUsuario.NickName}', '{nuevoUsuario.Contra}')";
            return veterinariaDAO.EjecutarComando(query);
        }

    }
}
