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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(TBLPRODUCTO model)
        {
            if (ModelState.IsValid)
            {
                using (BDFACTURACION db = new BDFACTURACION())
                {
                    db.TBLPRODUCTO.Add(model);
                    db.SaveChanges();
                    TempData["Mensaje"] = "Producto creado.";
                }
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(new BDFACTURACION().TBLCATEGORIA, "IdCategoria", "strNombre");
            return View(model);
        }

        public ActionResult Editar(int id)
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                ViewBag.IdCategoria = new SelectList(db.TBLCATEGORIA, "IdCategoria", "strNombre");
                return View(db.TBLPRODUCTO.Find(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(TBLPRODUCTO model)
        {
            if (ModelState.IsValid)
            {
                using (BDFACTURACION db = new BDFACTURACION())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Mensaje"] = "Producto actualizado.";
                }
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(new BDFACTURACION().TBLCATEGORIA, "IdCategoria", "strNombre");
            return View(model);
        }

        [HttpGet]
        public ActionResult Borrar(int id)
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                var producto = db.TBLPRODUCTO.Find(id);
                db.TBLPRODUCTO.Remove(producto);
                db.SaveChanges();
                TempData["Mensaje"] = "Producto eliminado.";
            }
            return RedirectToAction("Index");
        }
    }

}