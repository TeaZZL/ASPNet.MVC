using ASPNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            Author autor1 = new Author() { ID = 1, Ime = "Ivo", Prezime = "Ivanić", Starost = 45 };
            Author autor2 = new Author() { ID = 2, Ime = "Slavko", Prezime = "Borić", Starost = 60 };
            Author autor3 = new Author() { ID = 3, Ime = "Ana", Prezime = "Boto", Starost = 37 };


            List<Book> knjige = new List<Book>();
            knjige.Add(new Book() { Naslov = "Ljeto", Cijena = 45.5m, Autor = autor1 });
            knjige.Add(new Book() { Naslov = "Jesen", Cijena = 60, Autor = autor3 });
            knjige.Add(new Book() { Naslov = "Proljeće", Cijena = 30.5m, Autor = autor2 });
            knjige.Add(new Book() { Naslov = "Zima", Cijena = 25.99m, Autor = autor1 });
            knjige.Add(new Book() { Naslov = "Starost svemira", Cijena = 19.99m, Autor = autor3 });
            return View("Exam", knjige);

        }
    }
}
