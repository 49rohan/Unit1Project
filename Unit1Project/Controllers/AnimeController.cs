using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unit1Project.Models;

namespace Unit1Project.Controllers
{
    public class AnimeController : Controller
    {
        private static readonly List<string> AnimeLastNames = new List<string>
        {
            "Uzumaki", "Yagami", "Todoroki", "Ackerman", "Kurosaki", "Uchiha", "Zoldyck", "Kirigaya", "Nara", "Kageyama"
        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                Random rnd = new Random();
                string randomLastName = AnimeLastNames[rnd.Next(AnimeLastNames.Count)];
                string fullName = $"{model.Name} {randomLastName}";

                return RedirectToAction("AnimeList", new { fullName = fullName });
            }

            return View(model);
        }
        public IActionResult AnimeList(string fullName)
        {
            ViewBag.FullName = fullName;

            var topAnimes = new List<string>
        {
            "Sousou no Frieren",
            "Fullmetal Alchemist: Brotherhood",
            "Steins;Gate",
            "Gintama",
            "Shingeki no Kyojin Season 3 Part 2",
            "Gintama: The Final",
            "Hunter x Hunter (2011)",
            "Monogatari Series: Off & Monster Season",
            "Bleach: Sennen Kessen-hen"
        };

            return View(topAnimes);
        }

    }
}
