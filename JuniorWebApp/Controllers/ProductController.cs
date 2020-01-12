using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JuniorWebApp.Services;
using JuniorWebApp.Models;

namespace JuniorWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            if(!_productService.HasProducts())
            {
                return Content("Nie znaleziono żadnych produktów!");
            }

            var products = _productService.GetProducts();

            return View(products.ToArray());
        }

        public IActionResult GetProduct(Guid id)
        {
            var product = _productService.GetProduct(id);

            if(product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public Guid PostProduct(ProductCreateRequestDto request)
        {
            if(ModelState.IsValid)
            {
                var guid = _productService.AddProduct(request.Name, request.Price);

                return guid;
            }
            else
            {
                return Guid.Empty;
            }
        }

        public IActionResult PutProduct(ProductUpdateRequestDto request)
        {
            if(ModelState.IsValid)
            {
                _productService.UpdateProduct(request.Id, request.Name, request.Price);

                return View(request);
            }
            else
            {
                return Content("Błędne dane");
            }
        }

        public IActionResult DeleteProduct(Guid id)
        {
            var result = _productService.DeleteProduct(id);

            if(result)
            {
                return Content("Usunięto produkt o ID: " + id);
            }
            else
            {
                return Content("Nie znaleziono produktu o podanym ID");
            }
        }
    }
}