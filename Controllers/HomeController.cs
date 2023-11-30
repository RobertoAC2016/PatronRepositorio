using DALayer.Entities;
using DALayer.Repository;
using Microsoft.AspNetCore.Mvc;
using PatronRepositorio.Models;
using System.Diagnostics;

namespace PatronRepositorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStateRepository _repository;

        public HomeController(IStateRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ShowStates()
        {
            List<State> lstStates = await _repository.GetStates();
            return View(lstStates);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}