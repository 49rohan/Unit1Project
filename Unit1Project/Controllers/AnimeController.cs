using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unit1Project.Models;

namespace Unit1Project.Controllers
{
    public class AnimeController : Controller
    {
        //List of anime last names that is readonly 
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
            if (ModelState.IsValid) //Checks if the model state is valid
            {
                Random rnd = new Random(); //Creates an instance from the random class to generate a random numbers
                string randomLastName = AnimeLastNames[rnd.Next(AnimeLastNames.Count)]; //Selects a random number that is generated and goes through the AnimeLastNames
                                                                                        //to select a random name and then stores it in randomLastName
                string fullName = $"{model.Name} {randomLastName}"; //Gets the name from the form and appends the random last name to it

                return RedirectToAction("AnimeList", new { fullName = fullName }); //Redirects to the AnimeList.cshtml file with the new full name
            }

            return View(model); //return model if model state is not valid
        }

        public IActionResult AnimeList(string fullName)
        {
            ViewBag.FullName = fullName; //Display full name from the ViewBag

            var topAnimes = new List<string> //List of the top rated animes from "myanimelist"
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

            return View(topAnimes); //return the list of animes
        }

    }
}
