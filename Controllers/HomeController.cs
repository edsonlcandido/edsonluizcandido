using Microsoft.AspNetCore.Mvc;

namespace edsonluizcandido.Controllers
{
    
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Title = "Edson Luiz Candido";
            var md = System.IO.File.ReadAllText("wwwroot/Index.md");
            string html = Markdig.Markdown.ToHtml(md);
            return View("View", html);
        }

        [Route("/programacao")]
        public IActionResult Programacao()
        {
            ViewBag.Title = "Edson Luiz Candido";
            var md = System.IO.File.ReadAllText("wwwroot/EdsonLuizCandidoProgramacao.md");
            string html = Markdig.Markdown.ToHtml(md);
            return View("View", html);
        }

        [Route("/novo")]
        public IActionResult Novo()
        {
            ViewBag.Title = "Edson Luiz Candido";
            var md = System.IO.File.ReadAllText("wwwroot/EdsonLuizCandido.md");
            string html = Markdig.Markdown.ToHtml(md);
            return View("View", html);
        }
    }
}
