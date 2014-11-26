using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios;

namespace GestionCursos.Models.ViewModels
{
    public class CursoViewModel:IViewModel<Curso>
    {
        public int idCurso { get; set; }
        public string nombre { get; set; }
        public Nullable<int> profesor { get; set; }
        public System.DateTime inicio { get; set; }
        public int duracion { get; set; }
        public List<int> idAulas { get; set; }

        public Curso ToBaseDatos()
        {
            var model = new Curso()
            {
                idCurso = idCurso,
                nombre = nombre,
                profesor = profesor,
                inicio = inicio,
                duracion = duracion
            };
            return model;
        }

        public void FromBaseDatos(Curso model)
        {
            idCurso = model.idCurso;
            nombre = model.nombre;
            profesor = model.profesor;
            inicio = model.inicio;
            duracion = model.duracion;
            try
            {
                idAulas = model.Aula.Select(o => o.idAula).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateBaseDatos(Curso model)
        {
            model.idCurso = idCurso;
            model.nombre = nombre;
            model.profesor = profesor;
            model.inicio = inicio;
            model.duracion = duracion;
        }

        public int[] GetPk()
        {
            return new[] {idCurso};
        }
    }
}