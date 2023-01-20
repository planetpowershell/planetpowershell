using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DaveCarroll : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Dave";
        public string LastName => "Carroll";
        public string ShortBioOrTagLine => "PowerShell developer and retro-computing enthusiast.";
        public string StateOrRegion => "Nashville, TN";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "thedavecarroll";
        public string MastodonHandle => "";
        public string GitHubHandle => "thedavecarroll";
        public string GravatarHash => "fd0387e212af38089603b5480e406545";
        public GeoPosition Position => new GeoPosition(36.0679, -86.7194);
        public Uri WebSite => new Uri("https://thedavecarroll.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://thedavecarroll.com/feed.xml"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}