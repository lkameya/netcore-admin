using AdminAPI.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminAPI.Services
{
    public interface IPostService
    {
        public Task<List<Post>> GetPostsAsync();
        public Task<Post> GetPostByIdAsync(int postId);
        public Task<bool> CreatePostAsync(Post post);
        public Task<bool> UpdatePostAsync(Post post);
        public Task<bool> DeletePostAsync(int postId);
        Task<bool> UserOwnsPostAsync(int postId, string userId);
    }
}
