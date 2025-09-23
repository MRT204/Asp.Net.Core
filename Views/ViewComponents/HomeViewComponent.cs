using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Views.ViewComponents
{
    public class HomeViewComponent : ViewComponents
    {
        protected Home home = new Home();
        public IViewComponentResult Invoke()
        {
            var homes = home.GetHomeList();
            return View(homes);
        }
    }
}