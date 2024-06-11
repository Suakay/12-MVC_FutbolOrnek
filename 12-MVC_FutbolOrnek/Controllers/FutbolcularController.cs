using _12_MVC_FutbolOrnek.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12_MVC_FutbolOrnek.Controllers
{
    public class FutbolcularController : Controller
    {

    
        private readonly ApplicationDbContext _context;//Field

    
        public FutbolcularController(ApplicationDbContext context)
         {
            _context=context;   
         }
        public IActionResult Index()
        {
        List<Futbolcu> futbolcular = _context.Futbolcular.ToList();
        return View(futbolcular);
        }
        public IActionResult Create()
        {
            VMCreateFutbolcular vMCreateFutbolcu=new VMCreateFutbolcular();   
            vMCreateFutbolcu.Mevkiler=_context.Mevkiler.ToList();
            vMCreateFutbolcu.Takimlar=_context.Takimlar.ToList();

            return View(vMCreateFutbolcu);
        }
        public IActionResult Add()
        {
            VMCreateFutbolcular vMCreateFutbolcu = new VMCreateFutbolcular();
            vMCreateFutbolcu.Mevkiler = _context.Mevkiler.ToList();
            vMCreateFutbolcu.Takimlar = _context.Takimlar.ToList();

            return View(vMCreateFutbolcu);
        }
        [HttpPost]
        public IActionResult Create(Futbolcu futbolcu)
        {
           _context.Futbolcular.Add(futbolcu);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
