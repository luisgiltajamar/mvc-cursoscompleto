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
    }
}