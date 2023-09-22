using System.Text.Json;

namespace DesignPatterns.Structural.Decorator
{
    public class PostService : IPostService
    {
        public PostService()
        {
        }

        public async Task<Post?> GetPost(int postId)
        {
            return new Post()
            {
                Id = postId,
                Body = "Post Body",
                Title = "Post Title",
                UserId = 1
            };
        }
    }
}
