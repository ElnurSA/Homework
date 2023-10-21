using System;
using Service.Services;
using Service.Services.Interfaces;

namespace TodayPractice.Controllers
{
	public class BlogController
	{
		private readonly IBlogService _blogService;

		public BlogController()
		{
			_blogService = new BlogService();
		}

		public void GetAll()
		{
			var blogs = _blogService.GetAll();

			for (int i = 0; i < blogs.Length; i++)
			{
				string result = $"{blogs[i].ID} - {blogs[i].Title} - {blogs[i].Description}";
				Console.WriteLine(result);
			}
		}

		public void GetById()
		{
			var blog = _blogService.GetByID(2);

			string result = $"{blog.ID} - {blog.Title} - {blog.Description}";
			Console.WriteLine(result);

		}
	}
}

