namespace DesignPatterns.Structural.Decorator
{
    public interface IPostService
    {
        Task<Post?> GetPost(int postId);
    }
}
