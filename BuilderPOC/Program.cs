using BuilderPOC.Models;

namespace BuilderPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMediaPost post = new SocialMediaBuilder()
                .SetUserName("James")
                .SetLikeCount(10000)
                .SetLocation("Goa")
                .SetCaption("Hot Vibe")
                .SetImageLink(@"Https\\:PostAtSocialMedia.com")
                .SetPostDate(DateTime.Now)
                .Build();

            Console.WriteLine(post.ToString());
        }
    }
}
