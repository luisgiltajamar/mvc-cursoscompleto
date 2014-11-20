using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using GestionCursos.Models;
using GestionCursos.Repositorios;

namespace GestionCursos.Controllers
{
    public class ComunesController : Controller
    {
        

        RepositorioMenu repo=new RepositorioMenu(new CursosDemoEntities());

        public ActionResult Menu()
        {
            return View(repo.Get());
        }
    }
}



