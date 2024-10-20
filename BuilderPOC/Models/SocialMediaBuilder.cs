using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPOC.Models
{
    internal class SocialMediaBuilder
    {
        private readonly SocialMediaPost post = new SocialMediaPost();

        public SocialMediaBuilder SetLikeCount(int count)
        {
            post.Likes = count;
            return this;
        }
        public SocialMediaBuilder SetUserName(string userName)
        {
            post.UserName = userName;
            return this;
        }
        public SocialMediaBuilder SetCaption(string caption)
        {
            post.Caption = caption;
            return this;
        }
        public SocialMediaBuilder SetLocation(string location)
        {
            post.Location=location;
            return this;
        }
        public SocialMediaBuilder SetImageLink(string link)
        {
            post.ImageLink = link;
            return this;
        }
        public SocialMediaBuilder SetPostDate(DateTime postDate) { 
            post.PostDate = postDate;
            return this;
        }

        public SocialMediaPost Build()
        {
            return post;
        }
    }
}
