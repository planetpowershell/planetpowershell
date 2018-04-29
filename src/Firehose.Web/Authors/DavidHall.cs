using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class DavidHall : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "David";
        public string LastName => "Hall";
        public string ShortBioOrTagLine => "Microsoft PowerShell Enthusiast. Founder of SignalWarrant.com";
        public string StateOrRegion => "Georgia, USA";
        public string TwitterHandle => "signalwarrant";
        public string GitHubHandle => "signalwarrant";
        public string GravatarHash => "afd7acd25c1511435fd85cdeda29aa43";
        public GeoPosition Position => new GeoPosition(33.281, -82.0743);

        public Uri WebSite => new Uri("https://signalwarrant.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://signalwarrant.com/feed/"); } }
        
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}