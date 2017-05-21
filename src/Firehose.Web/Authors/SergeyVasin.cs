using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SergeyVasin : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Sergey";
        public string LastName => "Vasin";
        public string ShortBioOrTagLine => "IT Pro, Microsoft Trainer, Cisco Instructor, PowerShell UserGroup Lead";
        public string StateOrRegion => "Yoshkar-Ola, Russia";
        public string EmailAddress => "seth.vs@gmail.com";
        public string TwitterHandle => "vsseth";
        public string GravatarHash => "3baf621c02b71b2333643f4e69791dbd";
        public string GitHubHandle => "sethvs";
        public GeoPosition Position => new GeoPosition(56.63093, 47.89091);
        public Uri WebSite => new Uri("https://sergeyvasin.net");
        
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://sergeyvasin.net/feed/"); }
        }
        
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}
