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
    }
}
