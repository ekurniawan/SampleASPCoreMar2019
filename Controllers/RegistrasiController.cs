using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers {
    public class RegistrasiController : Controller{
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tampil(string Firstname,string Lastname)
        {
            return Content($"Nama : {Firstname} {Lastname}");
        }
    }
}