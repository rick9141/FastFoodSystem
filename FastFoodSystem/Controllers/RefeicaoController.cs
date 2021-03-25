using FastFoodSystem.Dal;
using FastFoodSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFoodSystem.Controllers
{
    public class RefeicaoController : Controller
    {
        private FastFoodContext db = new FastFoodContext();

        // GET: Refeicao
        public ActionResult Index()
        {
            return View(db.Refeicoes.ToList());
        }

        ///Cadastra Refeição
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Refeicao refeicao)
        {
            if (ModelState.IsValid)
            {
                db.Refeicoes.Add(refeicao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(refeicao);
        }

        
    }
}