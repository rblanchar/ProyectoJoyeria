﻿using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ServicioProducto
    {
        private string fileName = "producto.txt";
        RepositorioProducto repositorio;

        public List<Producto> productos;
        public ServicioProducto()
        {
            repositorio = new RepositorioProducto(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
        {
            productos = repositorio.ConsultarTodos();
        }
        public string Guardar(Producto producto)
        {
            var msg = repositorio.Guardar(producto.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Producto> Consultar()
        {
            return productos;
        }

        public Producto BuscarProducto(string id)
        {
            foreach (var item in productos)
            {
                if (item.Codigo == id)
                {
                    return item;
                }
            }
            return null;
        }

    }
}