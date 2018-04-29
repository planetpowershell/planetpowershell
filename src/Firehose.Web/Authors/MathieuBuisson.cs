using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class MathieuBuisson : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Mathieu";
        public string LastName => "Buisson";
        public string ShortBioOrTagLine => "Senior DevOps Engineer. Working on Dev, Ops and everything in between";
        public string StateOrRegion => "Dublin, Ireland";
        public string TwitterHandle => "TheShellNut";
        public string GravatarHash => "25061653796d5c748192c68e2eb6bde8";

        public Uri WebSite => new Uri("https://mathieubuisson.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mathieubuisson.github.io/feed.xml"); }
        }

        public string GitHubHandle => "MathieuBuisson";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }

        public GeoPosition Position => new GeoPosition(53.294469, -6.141136);
        public string FeedLanguageCode => "en";
    }
}