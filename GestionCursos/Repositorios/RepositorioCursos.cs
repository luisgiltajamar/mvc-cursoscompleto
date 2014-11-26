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
    public class RepositorioCursos:Repositorio<CursoViewModel,Curso>
    {
        public RepositorioCursos(DbContext context) : base(context)
        {
        }

        public List<CursoViewModel> GetPorProfesor(int id)
        {
            return Get(o => o.profesor.Value == id);
        }

        public override CursoViewModel Add(CursoViewModel modelo)
        {
            var aulas = Context.Set<Aula>().
                Where(o => modelo.idAulas.Contains(o.idAula));

            var datos = modelo.ToBaseDatos();
            datos.Aula = aulas.ToList();

            DbSet.Add(datos);
            Context.SaveChanges();

            modelo.FromBaseDatos(datos);
            return modelo;


            


        }
    }
}