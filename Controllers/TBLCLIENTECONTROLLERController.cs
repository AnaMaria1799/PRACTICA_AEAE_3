using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRACTICA_AEAE_3.Models;
using System.Data.Entity;


namespace PRACTICA_AEAE_3.Controllers
{
    public class TBLCLIENTECONTROLLERController : Controller
    {
        // GET: TBLCLIENTECONTROLLER
        public ActionResult Index()
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                return View(db.TBLCLIENTE.ToList());
            }
                
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(TBLCLIENTES model)

        {
            if (ModelState.IsValid)
            {
                using (BDFACTURACION db = new BDFACTURACION())
                {
                    db.TBLCLIENTE.Add(model);
                    db.SaveChanges();
                    TempData["Mensaje"] = "Cliente creado exitosamente.";
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Editar(int id)
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                return View(db.TBLCLIENTE.Find(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(TBLCLIENTES model)
        {
            if (ModelState.IsValid)
            {
                using (BDFACTURACION db = new BDFACTURACION())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Mensaje"] = "Cliente actualizado.";
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Borrar(int id)
        {
            using (BDFACTURACION db = new BDFACTURACION())
            {
                var cliente = db.TBLCLIENTE.Find(id);
                db.TBLCLIENTE.Remove(cliente);
                db.SaveChanges();
                TempData["Mensaje"] = "Cliente eliminado.";
            }
            return RedirectToAction("Index");
        }
    }
}