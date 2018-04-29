using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class DanFranciscus : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Dan";
        public string LastName => "Franciscus";
        public string ShortBioOrTagLine => "Sysadmin, PowerShell and Chocolatey evangelist, Blogger";
        public string StateOrRegion => "Belle Mead, New Jersey";
        public string TwitterHandle => "dan_franciscus";
        public string GravatarHash => "c99c2eda81dc29f5b8adaf625e4db414";

        public Uri WebSite => new Uri("https://winsysblog.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://winsysblog.com/feed/"); }
        }

        public string GitHubHandle => "dfranciscus";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }

        public GeoPosition Position => new GeoPosition(40.462445, 74.6744);
        public string FeedLanguageCode => "en";
    }
}
