namespace DesignPatterns.Structural.Proxy
{
    public interface IPostAPI
    {
        Task<Post?> GetPost(int postId);
    }
}
