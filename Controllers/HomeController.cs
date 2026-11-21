using Microsoft.AspNetCore.Mvc;
using NguyenKimManh_241230790De1.Models;
using System.Diagnostics;

namespace NguyenKimManh_241230790De1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using var db = new QltaiSanContext();
            var dsTaiSan = db.TaiSans.Where(x => x.NguyenGia >= 20).ToList();
            return View(dsTaiSan);
        }
        public IActionResult LocTheoLoai(int maLoai)
        {
            using var db = new QltaiSanContext();
            var dsTaiSan = db.TaiSans.Where(x => x.MaLoai == maLoai && x.NguyenGia >= 20).ToList();
            return PartialView("DanhSachTaiSan", dsTaiSan);
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
