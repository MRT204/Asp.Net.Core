using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetCoreMVCLab03.Controllers;

namespace NetCoreMVCLab03.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public flaot Price { get; set; }
        public int TotalPage { get; set; }

        public string Sumary { get; set; }
        List<Home> GetHomeList()
        {
            List<Home> Homes = new List<Home>()
            {
                new Home() {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Home()...,
                new Home()...,
                new Home()...
             };
            return Homes;

        }
    }
}
