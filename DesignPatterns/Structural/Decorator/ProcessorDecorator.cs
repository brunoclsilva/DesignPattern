namespace DesignPatterns.Structural.Decorator
{
    public class ProcessorDecorator
    {
        public ProcessorDecorator()
        {
            Console.WriteLine("Do you want to retrieve the post with log or not?");
            Console.WriteLine("1 - Without Log");
            Console.WriteLine("2 - With Log");
            Int32.TryParse(Console.ReadLine(), out int type);

            IPostService postService = new PostService();
            
            try
            {
                Task<Post>? post;
                if(type == (int)EnumCallType.WithoutLog)
                {
                    post = postService.GetPost(1);
                }
                else if (type == (int)EnumCallType.WithLog)
                {
                    var postServiceLogging = new PostServiceLoggingDecorator(postService);
                    post = postServiceLogging.GetPost(1);
                }
                else
                {
                    throw new ArgumentException("You must choose a type from the list above!");
                }
                 
                post.Result.PrintProperties();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
