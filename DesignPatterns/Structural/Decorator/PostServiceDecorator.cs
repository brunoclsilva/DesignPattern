namespace DesignPatterns.Structural.Decorator
{
    public abstract class PostServiceDecorator : IPostService
    {
        protected readonly IPostService postService;

        public PostServiceDecorator(IPostService postService)
        {
            this.postService = postService;
        }

        public abstract Task<Post?> GetPost(int postId);
    }
}
