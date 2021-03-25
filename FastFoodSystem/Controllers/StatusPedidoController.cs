using FastFoodSystem.Dal;
using FastFoodSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFoodSystem.Controllers
{
    public class StatusPedidoController : Controller
    {
        private FastFoodContext db = new FastFoodContext();

        // GET: StatusPedido
        public ActionResult Index()
        {
            return View(db.StatusPedidos.ToList());
        }

        ///Cadastra Status
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StatusPedido statuspedido )
        {
            if (ModelState.IsValid)
            {
                db.StatusPedidos.Add(statuspedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statuspedido);
        }
    }
}