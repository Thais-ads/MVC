using Microsoft.AspNetCore.Mvc;
using MVCI.Models;
using System.Diagnostics;

namespace MVCI.Controllers
{
    public class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            //instanciando a homeModel que vem da pasta Homemodels. 
            HomeModel home = new HomeModel();
            home.Nome = "Thais";
            home.Cpf = 123456789;
            
            return View(home);
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