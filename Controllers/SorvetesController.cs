using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sorveteriaMVC.context;
using sorveteriaMVC.Models;

namespace sorveteriaMVC.Controllers
{
    [Route("[controller]")]
    public class SorvetesController : Controller
    {
        private readonly ILogger<SorvetesController> _logger;
        private readonly AppDbContext _context;

        public SorvetesController(ILogger<SorvetesController> logger, AppDbContext context)

        {
            _logger = logger;
            _context = context;
        }
       
       [Route("Listar")]
        public IActionResult Listar()
        {
            var sorvetes = _context.Sorvetes.ToList();
            return View(sorvetes);
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(Sorvete sorvete)
        {
            _context.Sorvetes.Add(sorvete);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}