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
            var data = RepositorioProfesor.Get();
            return View(data);
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
               return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}