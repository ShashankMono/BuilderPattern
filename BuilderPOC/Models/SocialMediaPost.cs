using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPOC.Models
{
    internal class SocialMediaPost
    {
        public int Likes { get; set; }
        public string UserName { get; set; }
        public string Caption { get; set; }
        public string Location { get; set; }
        public string ImageLink { get; set; }
        public DateTime PostDate {  get; set; }

        public override string ToString()
        {
            return $"Likes : {Likes}\n" +
                $"UserName : {UserName}\n" +
                $"Caption : {Caption}\n" +
                $"Location : {Location}\n" +
                $"ImageLink : {ImageLink}\n" +
                $"Date : {PostDate}";
        }
    }
}
