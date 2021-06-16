using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using DAL;
namespace Day19.Controllers
{
    public class ProductController : Controller
    {
        ProductDAL dal = new ProductDAL();

        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Product> list = dal.Show();

            return Json(list);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product s)
        {
            int i = dal.Add(s);
            return Json(i);
        }
    }
}
