using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("AboutMe");
        }

        [Route("about-me")]
        public IActionResult AboutMe()
        {
            ViewBag.SidebarSection = SidebarSections.aboutme;
            ViewData["Title"] = "About Me";

            return View();
        }

        [Route("resume")]
        public IActionResult Resume()
        {
            ViewBag.SidebarSection = SidebarSections.resume;
            ViewData["Title"] = "Resume";

            return View();
        }

        [Route("education")]
        public IActionResult Education()
        {
            ViewBag.SidebarSection = SidebarSections.education;
            ViewData["Title"] = "Education";

            return View();
        }

        [Route("experience")]
        public IActionResult Experience()
        {
            ViewBag.SidebarSection = SidebarSections.experience;
            ViewData["Title"] = "Experience";

            return View();
        }

        [Route("skills")]
        public IActionResult Skills()
        {
            ViewBag.SidebarSection = SidebarSections.skills;
            ViewData["Title"] = "Skills";

            return View();
        }

        [Route("roadmap")]
        public IActionResult Roadmap()
        {
            ViewBag.SidebarSection = SidebarSections.roadmap;
            ViewData["Title"] = "Roadmap";

            return View();
        }

        [Route("projects")]
        public IActionResult Projects()
        {
            ViewBag.SidebarSection = SidebarSections.projects;
            ViewData["Title"] = "Projects";

            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            ViewBag.SidebarSection = SidebarSections.contact;
            ViewData["Title"] = "Contact";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}