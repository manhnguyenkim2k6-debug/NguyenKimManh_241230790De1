using Microsoft.AspNetCore.Mvc;
using NguyenKimManh_241230790De1.Models;
namespace NguyenKimManh_241230790De1.ViewComponents
{
    public class LoaiTaiSanViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var db = new QltaiSanContext();
            var dsLoai = db.LoaiTaiSans.ToList();
            return View(dsLoai);
        }
    }
}
