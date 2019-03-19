using Microsoft.AspNetCore.Mvc;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers {
    public class RegistrasiController : Controller{
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tampil(Anggota anggota)
        {
            return Content($"Nama : {anggota.Firstname} {anggota.Lastname}, {anggota.Address}, {anggota.Telp}");
        }
    }
}