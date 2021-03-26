using FastFoodSystem.Dal;
using FastFoodSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFoodSystem.Controllers
{
    public class PedidoController : Controller
    {
        private FastFoodContext db = new FastFoodContext();

        // GET: Pedido
        public ActionResult Index()
        {
            return View(db.Pedidos.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.ClienteList = new SelectList(db.Clientes, "Id", "Cpf", "Nome");
            ViewBag.RefeicaoList = new SelectList(db.Refeicaos, "IdRefeicao", "Tipo", "Valor");
            ViewBag.StatusList = new SelectList(db.StatusPedidos, "IdStatus", "Descricao");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Create([Bind(Include = "IdPedido,Cliente, Refeicao, FormaPag, StatusPedido")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                pedido.Cliente = db.Clientes.First(r => r.Cpf == pedido.Cliente.Cpf);
                pedido.Cliente = db.Clientes.First(r => r.Nome == pedido.Cliente.Nome);
                pedido.Refeicao = db.Refeicaos.FirstOrDefault(r => r.IdRefeicao == pedido.Refeicao.IdRefeicao);
                pedido.StatusPedido = db.StatusPedidos.FirstOrDefault(r => r.IdStatus == pedido.StatusPedido.IdStatus);
                
                db.Pedidos.Add(pedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }
        
        public ActionResult Edit(int id)
        {
            var pedido = db.Pedidos.First(d => d.IdPedido == id);
            ViewBag.ClienteList = new SelectList(db.Clientes, "Id", "Cpf", "Nome", pedido.IdPedido);
            ViewBag.RefeicaoList = new SelectList(db.Refeicaos, "IdRefeicao", "Tipo", "Valor", pedido.Refeicao.IdRefeicao);
            ViewBag.StatusList = new SelectList(db.StatusPedidos, "IdStatus", "Descricao", pedido.StatusPedido.IdStatus);
            return View(pedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPedido,Cliente, Refeicao, StatusPedido")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                Pedido pedidoUpdate = db.Pedidos.First(d => d.IdPedido == pedido.IdPedido);
                pedidoUpdate.StatusPedido = db.StatusPedidos.First(r => r.IdStatus == pedido.StatusPedido.IdStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }

        public ActionResult Details(int id)
        {
            return View(db.Pedidos.First(d => d.IdPedido == id));
        }


        public ActionResult Delete(int id)
        {
            return View(db.Pedidos.First(d => d.IdPedido == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            db.Pedidos.Remove(db.Pedidos.First(d => d.IdPedido == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}