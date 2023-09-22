namespace DesignPatterns.Structural.Proxy
{
    public class ProcessorProxy
    {
        public ProcessorProxy()
        {
        }

        public async Task Execute()
        {
            var api = new JSONPlaceholderAPI();
            var apiProxy = new JSONPlaceholderAPIProxy(api);

            var post1 = await apiProxy.GetPost(1);
            Console.WriteLine($"Post 1: {post1}");

            // Get post 1 again - should retrieve from cache
            var post1Cached = await apiProxy.GetPost(1);
            Console.WriteLine($"Post 1 (cached): {post1Cached}");
        }
    }
}
