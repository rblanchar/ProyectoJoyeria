﻿using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ModificarCateProducto
    {
        private string fileName = "Categoria.txt";
        ServicioCategoriaProducto servicioCategoriaProducto = new ServicioCategoriaProducto();
        RepositorioCategoriaProducto repositorio;
        RepositorioModificarCategoriaProducto categoriaProd;

        public ModificarCateProducto()
        {
            repositorio = new RepositorioCategoriaProducto(fileName);
            categoriaProd = new RepositorioModificarCategoriaProducto(fileName); 
        }

        public string ModificarCategoriaProducto(CategoriaProducto categoriaproducto)
        {
            var categoriaExistente = servicioCategoriaProducto.BuscarCodigo(categoriaproducto.Codigo);

            if (categoriaExistente != null)
            {
                categoriaExistente.NomCategoria = categoriaproducto.NomCategoria;

                categoriaProd.ActualizarCategoriaProducto(categoriaExistente);
                servicioCategoriaProducto.RefrescarLista(); 
                return "Categoría de producto modificada exitosamente.";
            }

            return "Categoría de producto no encontrada.";
        }

        public string EliminarCategoriaProducto(string codigo)
        {
            var categoriaExistente = servicioCategoriaProducto.BuscarCodigo(codigo);

            if (categoriaExistente != null)
            {
                categoriaProd.EliminarCategoriaProducto(codigo);

                return "Categoría de producto eliminada exitosamente.";
            }

            return "Categoría de producto no encontrada.";
        }

    }
}
