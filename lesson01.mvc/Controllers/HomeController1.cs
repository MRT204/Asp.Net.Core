using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lesson01.mvc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            // Truyền dữ liệu bằng ViewData
            ViewData["Message"] = "Chào mừng bạn đến với ASP.NET MVC!";
            ViewData["Date"] = DateTime.Now.ToString("dd/MM/yyyy");

            // Truyền danh sách
            ViewData["Names"] = new List<string> { "Lan", "Hùng", "Tú", "Mai" };

            return View();
        }
    }
}
