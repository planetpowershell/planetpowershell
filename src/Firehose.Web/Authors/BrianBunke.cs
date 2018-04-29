using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class BrianBunke : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Brian";
        public string LastName => "Bunke";
        public string ShortBioOrTagLine => "A self-deprecating Systems Automator interested in learning, testing, documenting, and open source.";
        public string StateOrRegion => "WA, USA";
        public string TwitterHandle => "brianbunke";
        public string GitHubHandle => "brianbunke";
        public string GravatarHash => "";

        public GeoPosition Position => new GeoPosition(48.751911, -122.478685);

        public Uri WebSite => new Uri("https://www.brianbunke.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.brianbunke.com/feed.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}
