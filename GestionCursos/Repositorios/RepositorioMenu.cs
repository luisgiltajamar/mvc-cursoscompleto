using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GestionCursos.Models;
using GestionCursos.Models.ViewModels;
using Repositorios;

namespace GestionCursos.Repositorios
{
    public class RepositorioMenu:Repositorio<MenusViewModel,Menus>
    {
        public RepositorioMenu(DbContext context) : base(context)
        {
        }

        public override List<MenusViewModel> Get()
        {
           var datos = Get(o => o.idPadre == null).OrderBy(o=>o.idMenu);

            foreach (var menusViewModel in datos)
            {
                menusViewModel.Hijos = new List<MenusViewModel>();
                CargarHijos(menusViewModel.Hijos,menusViewModel.idMenu);
            }


            return datos.ToList();
        }

        private void CargarHijos(List<MenusViewModel> datos, int idPadre)
        {
        var datosN = Get(o => o.idPadre == idPadre).OrderBy(o=>o.idMenu);

            foreach (var menusViewModel in datosN)
            {
                datos.Add(menusViewModel);
                menusViewModel.Hijos=new List<MenusViewModel>();
                CargarHijos(menusViewModel.Hijos,menusViewModel.idMenu);
            }


        }
    }
}