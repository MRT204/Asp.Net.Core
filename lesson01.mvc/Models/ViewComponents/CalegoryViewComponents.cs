using System.Drawing.Design;

namespace lesson01.mvc.Models.ViewComponents
{
    public class CalegoryViewComponents
    {
        public IViewComponnentResult Invoke()
        {
            List<Category> categories = new List<Category>()
            {
                new Category {CategoryId = 1, CategoryName = "Điện tử"},
                new Category {CategoryId = 1, CategoryName = "Điện lạnh"},
                new Category {CategoryId = 1, CategoryName = "Đồ da dụng"},
                new Category {CategoryId = 1, CategoryName = "Tiện ích"},
            };
            return View(categories);
        }
    }
}
