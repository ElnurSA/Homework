using System;
using Domain.Models;

namespace Services.Services.Interfaces
{
	public interface IProductService
	{
		public Product[] GetAll();
		public int GetCountProducts();
		public void SearchProduct();
		public Product[] ShowAll();
		public int AvaragePrice();
		public Product[] ShowByReverseChronology();
		public void GetByCategory();
		public void ShowCategories();
		public void GetByCategoryId();

	}
}

