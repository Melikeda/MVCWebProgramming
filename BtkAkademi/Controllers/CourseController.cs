using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]  //Bu attribute action metodunun sadece POST istekleri ile çağrılabileceğini söyler.
        [ValidateAntiForgeyToken]  //Bu attribute Cross-Site Request Forgery (CSRF) saldırılarını önler.
        public IActionResult Apply(Candidate model) //model binding
        {
            return View();
        }


    }
}
