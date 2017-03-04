using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class RyanMilne : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Ryan";
        public string LastName => "Milne";
        public string ShortBioOrTagLine => "IT Automation Fanatic";
        public string StateOrRegion => "West Midlands, United Kingdom";
        public string EmailAddress => "";
        public string TwitterHandle => "";
        public string GitHubHandle => "RyanMilne";
        public string GravatarHash => "9eaef5f58501b72e6ab5a487bf9e1cb8";
        public GeoPosition Position => new GeoPosition(52.4080, -1.5105);

        public Uri WebSite => new Uri("https://blog.milne.it/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.milne.it/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}