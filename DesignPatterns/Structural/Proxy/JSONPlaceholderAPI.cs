using System.Text.Json;

namespace DesignPatterns.Structural.Proxy
{
    public class JSONPlaceholderAPI : IPostAPI
    {
        public JSONPlaceholderAPI()
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
