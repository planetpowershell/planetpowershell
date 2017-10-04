using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PrateekSingh : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Prateek";
        public string LastName => "Singh";
        public string ShortBioOrTagLine => "Infrastructure Developer, Automation engineer and PowerShell Blogger";
        public string StateOrRegion => "New Delhi, India";
        public string EmailAddress => "prateeksingh1590@gmail.com";
        public string TwitterHandle => "SinghPrateik";
        public string GravatarHash => "2b2f100e9097063a5777a26820a58fc7";

        public Uri WebSite => new Uri("https://geekeefy.wordpress.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://geekeefy.wordpress.com/feed/"); }
        }

        public string GitHubHandle => "prateekkumarsingh";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }

        public GeoPosition Position => new GeoPosition(28.4594970, 77.0266380);
    }
}
