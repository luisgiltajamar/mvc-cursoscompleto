using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionCursos.Models.ViewModels;
using GestionCursos.Repositorios;

namespace GestionCursos.Controllers
{
    public class CursoController : BaseController
    {
        // GET: Curso
        public ActionResult Index()
        {
            var data = RepositorioCursos.Get();
            return View(data);
        }

        public ActionResult Alta()
        {
            ViewBag.profesor=new SelectList(RepositorioProfesor.Get(),"idProfesor","nombre");
            ViewBag.idAulas = new MultiSelectList(RepositorioAula.Get(), "idAula", "Nombre");
            return View(new CursoViewModel());
        }

        [HttpPost]
        public ActionResult Alta(CursoViewModel model)
        {
            if (ModelState.IsValid)
            {
                RepositorioCursos.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}