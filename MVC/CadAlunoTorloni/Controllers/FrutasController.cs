
using Microsoft.AspNetCore.Mvc;
using CadAlunoTorloni.Models;
namespace CadAlunoTorloni.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

            List<Fruta> listaFrutas = new List<Fruta>()
        {
            new Fruta { Id = 1, Nome = "Laranja", Cor = "Laranja", Categoria = "Cítrica" },
            new Fruta { Id = 2, Nome = "Limão", Cor = "Verde", Categoria = "Cítrica" },
            new Fruta { Id = 3, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Tropical" },
            new Fruta { Id = 4, Nome = "Manga", Cor = "Amarelo", Categoria = "Tropical" },
            new Fruta { Id = 5, Nome = "Morango", Cor = "Vermelho",  Categoria = "Tropical" }
        };
        public IActionResult Index()
        {
            return View(listaFrutas);
        }
        public IActionResult FrutasCitricas()
        {
            return View();
        }
        public IActionResult FrutasTropicais()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}