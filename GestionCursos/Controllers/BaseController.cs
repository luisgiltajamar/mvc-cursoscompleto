using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionCursos.Models;
using GestionCursos.Models.ViewModels;
using GestionCursos.Repositorios;
using Repositorios;

namespace GestionCursos.Controllers
{
    public class BaseController : Controller
    {

        private CursosDemoEntities _db;

        #region Repositorios

        private IRepositorio<ProfesorViewModel, Profesor> _repositorioProfesor;

        public IRepositorio<ProfesorViewModel, Profesor> RepositorioProfesor
        {
            get
            {
                if (_repositorioProfesor == null)
                    _repositorioProfesor =
                        new Repositorio<ProfesorViewModel, Profesor>(_db);
                return _repositorioProfesor;
            }

        }
        private RepositorioCursos _repositorioCursos;

        public RepositorioCursos RepositorioCursos
        {
            get
            {
                if (_repositorioCursos == null)
                    _repositorioCursos =
                        new RepositorioCursos(_db);
                return _repositorioCursos;
            }

        }
        #endregion

        public BaseController()
        {
            _db=new CursosDemoEntities();
        }



    }
}