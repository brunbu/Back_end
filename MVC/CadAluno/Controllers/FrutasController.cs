using AspNetCoreGeneratedDocument;
using CadAluno.Models;
using Microsoft.AspNetCore.Mvc;
namespace CadAluno.Controllers
{
    public class FrutaController : Controller
    {
        private readonly ILogger<FrutaController> _logger;

        public FrutaController(ILogger<FrutaController> logger)
        {
            _logger = logger;
        }

        List<Frutas> Fruta = new List<Frutas>()
        {
            new Frutas { Id = 1, Nome = "Laranja", Cor = "Laranja", Categoria = "Cítrica" },
            new Frutas { Id = 2, Nome = "Limão", Cor = "Verde", Categoria = "Cítrica" },
            new Frutas { Id = 3, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Tropical" },
            new Frutas { Id = 4, Nome = "Manga", Cor = "Amarelo", Categoria = "Tropical" },
            new Frutas { Id = 5, Nome = "Morango", Cor = "Vermelho",  Categoria = "Tropical" }
        };

        public IActionResult Index()
        {
            return View(Fruta);
        }
        public IActionResult FrutasTropicais()
        {
            return View();
        }
        public IActionResult FrutasCitricas()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
       
       public IActionResult Create(Frutas fruta)
        {
            Fruta.Add(fruta);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}