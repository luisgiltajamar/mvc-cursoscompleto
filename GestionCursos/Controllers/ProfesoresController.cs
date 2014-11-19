using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionCursos.Models.ViewModels;

namespace GestionCursos.Controllers
{
    public class ProfesoresController : BaseController
    {
        // GET: Profesores
        public ActionResult Index()
        {
            return View(RepositorioProfesor.Get());
        }

        public ActionResult NuevoProfesor()
        {
            return View(new ProfesorViewModel());
        }

        [HttpPost]
        public ActionResult NuevoProfesor(ProfesorViewModel model)
        {
            if (ModelState.IsValid)
            {
                RepositorioProfesor.Add(model);
                RedirectToAction("Index");
            }
            return View(model);
        }

    }
}