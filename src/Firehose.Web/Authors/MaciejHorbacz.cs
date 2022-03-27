using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MaciejHorbacz : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Maciej";
        public string LastName => "Horbacz";
        public string ShortBioOrTagLine => "PowerShell and Intune are my thing ⚔️";
        public string StateOrRegion => "Gdansk, Poland";
        public string EmailAddress => "maciej.horbacz@gmail.com";
        public string TwitterHandle => "Universecitiz3n";
        public string GitHubHandle => "Universecitiz3n";
        public string GravatarHash => "f59ba35493d7f1b99e25b6455dc39f5b";
        public GeoPosition Position => new GeoPosition(54.3520,18.6466);
        public Uri WebSite => new Uri("https://universecitiz3n.tech");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://universecitiz3n.tech/feed.xml"); } }
        public string FeedLanguageCode => "en";
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
        }
    }
}
