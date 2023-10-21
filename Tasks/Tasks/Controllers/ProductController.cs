using System;
using Services.Services;
using Services.Services.Interfaces;

namespace Tasks.Controllers
{
	public class ProductController
	{
        private readonly IProductService _productService;

        
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void ShowCount()
        {
            int count = _productService.GetCountProducts();

            Console.WriteLine(count);
        }

        public void Search()
        {
            _productService.SearchProduct();
        }

        public void ShowAll()
        {
            var products =  _productService.ShowAll();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Category}");
            }

        }

        public void ShowAvaragePrice()
        {
            int avaragePrice = _productService.AvaragePrice();

            Console.WriteLine(avaragePrice);

        }

        public void ShowByReverseDates()
        {
            var products = _productService.ShowByReverseChronology();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Category} - {product.Price} - {product.CreatedDate}");
            }
        }

        public void GetCategory()
        {
            _productService.GetByCategory();
            
        }

        public void ShowCategories()
        {
            _productService.ShowCategories();
        }

        public void GetCategoriesByID()
        {
            _productService.GetByCategoryId();
        }
    }

    
}

