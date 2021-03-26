using FastFoodSystem.Dal;
using FastFoodSystem.Models;
using System.Linq;
using System.Web.Mvc;

namespace FastFoodSystem.Controllers
{
    public class RefeicaoController : Controller
    {
        private FastFoodContext db = new FastFoodContext();

        // GET: Refeicao
        public ActionResult Index()
        {
            return View(db.Refeicaos.ToList());
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
                db.Refeicaos.Add(refeicao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(refeicao);
        }

        
    }
}