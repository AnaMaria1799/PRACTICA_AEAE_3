using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRACTICA_AEAE_3.Models;
using System.Data.Entity;

namespace PRACTICA_AEAE_3.Controllers
{
    public class TBLPRODUCTOController : Controller
    {
        // GET: TBLPRODUCTO
        public ActionResult Index()
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                ViewBag.IdCategoria = new SelectList(db.TBLCATEGORIA, "IdCategoria", "strNombre");
                return View(db.TBLPRODUCTO.Include(p => p.TBLCATEGORIA).ToList());
            }
        }

        public ActionResult Nuevo()
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                ViewBag.IdCategoria = new SelectList(db.TBLCATEGORIA, "IdCategoria", "strNombre");
                return View();
            }
        }
    }
}