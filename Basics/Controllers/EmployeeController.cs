using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ali",
                "Veli",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3() //Bu metodun döndürdüğü tür.Bu, metot farklı türde cevaplar (View, JSON, Redirect, Content vs.) döndürebileceği anlamına gelir.s
        {
            var list = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Melike", LastName = "Kulahci", Age = 24 },
                new Employee() { Id = 2, FirstName = "Deniz", LastName = "Yol", Age = 35 },
                new Employee() { Id = 3, FirstName = "Adem", LastName = "Gunes", Age = 12 }
            };
            return View("Index3", list);
        }
    }
}