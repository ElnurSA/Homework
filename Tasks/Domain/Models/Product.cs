using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}

