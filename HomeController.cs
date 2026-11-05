using Microsoft.AspNetCore.Mvc;
using MyBusinessCard.Models;

namespace MyBusinessCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name, int? year, string bio)
        {
            var person = new Person
            {
                FullName = name ?? "Имя не указано",
                
                BirthDate = new DateTime(year ?? 2000, 1, 1),
                
                Description = bio ?? "Описание пока не заполнено."
            };

            return View(person);
        }
    }
}
