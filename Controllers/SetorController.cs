using Cad1.Context;
using Cad1.Models;
using Microsoft.AspNetCore.Mvc;
namespace Cad1.Controllers
{
    public class SetorController : Controller
    {
        private readonly AppDbContext _context;
        public SetorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var setores = _context.Setores.ToList();
            return View(setores);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Setor setor)
        {
            if (ModelState.IsValid)
            {
                _context.Setores.Add(setor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(setor);
            }
        }
        public IActionResult Detalhar(int id)
        {
            var setor = _context.Setores.Find(id);
            if (setor == null)
                return RedirectToAction(nameof(Index));
            return View(setor);
        }
        public IActionResult Editar(int id)
        {
            var setor = _context.Setores.Find(id);
            if (setor == null)
                return RedirectToAction(nameof(Index));
            return View(setor);
        }
        [HttpPost]
        public IActionResult Editar(Setor setor)
        {
            var setorDb = _context.Setores.Find(setor.SetorId);
            setorDb.Nome = setor.Nome;
            _context.Setores.Update(setorDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var setor = _context.Setores.Find(id);
            if (setor == null)
                return RedirectToAction(nameof(Index));
            return View(setor);
        }
        [HttpPost]
        public IActionResult Deletar(Setor setor)
        {
            var setorDb = _context.Setores.Find(setor.SetorId);
            _context.Setores.Remove(setorDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}