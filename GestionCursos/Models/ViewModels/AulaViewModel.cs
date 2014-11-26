using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios;

namespace GestionCursos.Models.ViewModels
{
    public class AulaViewModel:IViewModel<Aula>
    {
        public int idAula { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }
        public Aula ToBaseDatos()
        {
            var model = new Aula()
            {
                capacidad = capacidad,
                nombre = nombre,
                idAula = idAula

            };
            return model;
        }

        public void FromBaseDatos(Aula model)
        {
            capacidad = model.capacidad;
            nombre = model.nombre;
            idAula = model.idAula;
        }

        public void UpdateBaseDatos(Aula model)
        {
            model.capacidad = capacidad;
            model.nombre = nombre;
            model.idAula = idAula;
        }

        public int[] GetPk()
        {
            return new[] {idAula};
        }
    }
}