using System;
using Domain.Models;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class BlogService : IBlogService
    {

        public Blog[] GetAll()
        {
            return Blogs(); 
        }

        public Blog GetByID(int id)
        {
            Blog existBlog = Blogs().FirstOrDefault(m => m.ID == id);
            return existBlog;
        }

        private Blog[] Blogs()
        {
            return new Blog[]
            {
                new Blog{ ID = 1, Title = "Tets1", Description = "desc1" },
                new Blog{ ID = 2, Title = "Tets2", Description = "desc2" },
                new Blog{ ID = 3, Title = "Tets3", Description = "desc3" }
            };
        }
    }
}

