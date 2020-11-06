using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        private ISportsStoreRepository repository;
        ProductsController(ISportsStoreRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
