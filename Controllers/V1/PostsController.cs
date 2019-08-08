using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using netcore_admin.Contracts.V1;
using netcore_admin.Contracts.V1.Requests;
using netcore_admin.Contracts.V1.Response;
using netcore_admin.Domain;

namespace netcore_admin.Controllers.V1
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

        [HttpPost(ApiRoutes.Posts.Create)]
        public IActionResult Create([FromBody] CreatePostRequest postRequest)
        {
            var post = new Post { Id = postRequest.Id };

            if (string.IsNullOrEmpty(post.Id))
                post.Id = Guid.NewGuid().ToString();

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.Posts.Get.Replace("{postId}", post.Id);

            var response = new CreatePostResponse { Id = post.Id };

            return Created(locationUri, response);
        }
    }
}
