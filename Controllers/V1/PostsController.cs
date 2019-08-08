using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using netcore_admin.Contracts;
using netcore_admin.Domain;

namespace netcore_admin.Controllers
{
    public class PostsController : Controller
    {
        private List<Post> _posts;
        public PostsController()
        {
            _posts = new List<Post>();
            for(var i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}