﻿using DATOS_ORACLE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;


namespace LOGICA_ORACLE
{
    public class ServicioUsuarioOracle
    {
        RepositorioUsuarioOracle repositorio = new RepositorioUsuarioOracle();
        ServicioTipoUsuarioOracle servicioTipoUsuario = new ServicioTipoUsuarioOracle();
        public string InsertarUsuario(Usuario usuario)
        {
            var msg = repositorio.InsertarUsuario(usuario);
            return msg;
        }

        public List<Usuario> usuarios;

        public List<Usuario> Consultar()
        {
            usuarios = repositorio.ObtenerTodosUsuarios();
            return usuarios;
        }

        public Usuario BuscarId(string id)
        {
            foreach (var usuario in Consultar())
            {
                if (usuario.Id_Usuario == id)
                {
                    return usuario;
                }
            }
            return null;
        }
        public string ModificarUsuario(Usuario Usuario)
        {
            var msg = repositorio.ModificarUsuario(Usuario);
            return msg;
        }
        public string EliminarUsuario(string id)
        {
            var msg = repositorio.EliminarUsuario(id);
            return msg;
        }

        public List<Usuario> BuscarFiltro(string valor)
        {
            List<Usuario> listaFiltrada = new List<Usuario>();

            foreach (var item in usuarios)
            {
                TipoUsuario NombreTipo = servicioTipoUsuario.BuscarId(item.tipoUsuario.IdTipo.ToString());
                if (item.Nombre.Contains(valor) || item.Apellidos.Contains(valor) || NombreTipo.Nombre.Contains(valor))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
        public string ProximoidUsuario()
        {
            return repositorio.ProximoIdUsuario();
        }

        public Usuario Loguin(string user, string pass)
        {
            var usuario = repositorio.ObtenerUsuarioPorCredenciales(user, pass);

            if (usuario != null)
            {
                return usuario;
            }

            return null;
        }
    }
}
