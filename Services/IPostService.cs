using netcore_admin.Domain;
using System;
using System.Collections.Generic;

namespace netcore_admin.Services
{
    public interface IPostService
    {
        public List<Post> GetPosts();
        public Post GetPostById(Guid postId);
        public bool UpdatePost(Post post);
    }
}
