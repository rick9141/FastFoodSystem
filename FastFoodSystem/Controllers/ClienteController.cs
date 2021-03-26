using FastFoodSystem.Dal;
using FastFoodSystem.Models;
using System.Linq;
using System.Web.Mvc;

namespace FastFoodSystem.Controllers
{
    public class ClienteController : Controller
    {

        private FastFoodContext db = new FastFoodContext();


        // GET: Cliente

        ///Lista Cliente
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        ///Cadastra Cliente
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        ///Edita Cliente puxa por pk
        public ActionResult Edit(int id)
        {
            return View(db.Clientes.First(d => d.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                Cliente clienteUpdate = db.Clientes.First(d => d.Id == cliente.Id);
                clienteUpdate.Cpf = cliente.Cpf;
                clienteUpdate.Nome = cliente.Nome;
                clienteUpdate.Telefone = cliente.Telefone;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        ///Detalhes de um certo cadastro puxa pela primary key (id)
        public ActionResult Details(int id)
        {
            return View(db.Clientes.First(d => d.Id == id));
        }

        ///Deleta puxa pela primary key (id)
        public ActionResult Delete(int id)
        {
            return View(db.Clientes.First(d => d.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var cliente = db.Clientes.First(d => d.Id == id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}