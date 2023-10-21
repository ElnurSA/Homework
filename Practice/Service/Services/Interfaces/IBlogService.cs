using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IBlogService
	{
		Blog[] GetAll();
		Blog GetByID(int a);
	}
}

