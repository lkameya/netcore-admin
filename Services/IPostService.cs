using netcore_admin.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace netcore_admin.Services
{
    public interface IPostService
    {
        public Task<List<Post>> GetPostsAsync();
        public Task<Post> GetPostByIdAsync(int postId);
        public Task<bool> CreatePostAsync(Post post);
        public Task<bool> UpdatePostAsync(Post post);
        public Task<bool> DeletePostAsync(int postId);
    }
}
