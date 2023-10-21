using System;
using Domain.Models;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class ProductService : Product, IProductService
    {
        public Product[] GetAll()
        {

            return new Product[]
            {
                new Product{ID = 1, Category = "Phone", CreatedDate = new DateTime(2023,09,09), Name = "iPhone 15", Price = 4000  },
                new Product{ID = 2, Category = "Computer", CreatedDate = new DateTime(2022,01,05), Name = "MacBook Pro", Price = 2000  },
                new Product{ID = 3, Category = "Headphones", CreatedDate = new DateTime(2021,05,09), Name = "AirPods Max", Price = 1500  }

            };
           
        }

        public int GetCountProducts()
        {
            Product[] products = GetAll();

            int count = 0;

            foreach (var item in products)
            {
                count++;
            }
            return count;

        }

        public void SearchProduct()
        {
            Product[] products = GetAll();
            int count = 0;
            string searchText = Console.ReadLine();

            foreach (var product in products)
            {
                if(product.Name.Contains(searchText))
                {
                    Console.WriteLine($"{product.Name} - {product.Price} - {product.Category}");
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No products found");
            }

            
        }

        public Product[] ShowAll()
        {
            Product[] products = GetAll();

            return products;

        }

        public int AvaragePrice()
        {
            Product[] products = GetAll();

            int sumOfPrice = 0;

            int count = 0;

            int avarageOfPrices = 0;

            foreach (var product in products)
            {
                count++;
                sumOfPrice += product.Price;


            }

            avarageOfPrices = sumOfPrice / count;

            return avarageOfPrices;
        }

        public Product[] ShowByReverseChronology()
        {
            Product[] products = GetAll();
            products.OrderByDescending(m => m.CreatedDate);
            return products;
        }

        public void GetByCategory()
        {
            Product[] products = GetAll();

            foreach (var product in products)
            {
                if (product.Category.Contains(product.Name))
                {
                    Console.WriteLine($"{product.Name} - {product.Category} - {product.CreatedDate} - {product.Price}");
                }
            }
            

        }

        public void ShowCategories()
        {
            Product[] products = GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.Category);
            }
        }

        public void GetByCategoryId()
        {
            Product[] products = GetAll();
            int id = 3;

            foreach (var product in products)
            {
                if(product.ID == id)
                {
                    Console.WriteLine($"{product.Name} - {product.Price} - {product.CreatedDate}");
                }
            }

        }

        
    }
}

