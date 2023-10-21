using System;
namespace Domain.Models
{
	public abstract class BaseEntity
	{
		public int ID { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
	}
}

