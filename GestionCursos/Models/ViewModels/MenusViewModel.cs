using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios;

namespace GestionCursos.Models.ViewModels
{
    public class MenusViewModel:IViewModel<Menus>
    {

        public int idMenu { get; set; }
        public string Nombre { get; set; }
        public string controlador { get; set; }
        public string accion { get; set; }
        public bool visible { get; set; }
        public Nullable<int> idPadre { get; set; }
        public string url { get; set; }
        public List<MenusViewModel> Hijos { get; set; }


        public Menus ToBaseDatos()
        {
            var datos = new Menus()
            {
                idMenu = idMenu,
                Nombre = Nombre,
                controlador = controlador,
                accion = accion,
                visible = visible,
                idPadre = idPadre,
                url = url
            };
            return datos;
        }

        public void FromBaseDatos(Menus model)
        {
            idMenu = model.idMenu;
            Nombre = model.Nombre;
            controlador = model.controlador;
            accion = model.accion;
            visible = model.visible;
            idPadre = model.idPadre;
            url = model.url;

            

        }

        public void UpdateBaseDatos(Menus model)
        {
            model.idMenu = idMenu;
            model.Nombre = Nombre;
            model.controlador = controlador;
            model.accion = accion;
            model.visible = visible;
            model.idPadre = idPadre;
            model.url = url;
        }

        public int[] GetPk()
        {
            return new []{idMenu};
        }
    }
}