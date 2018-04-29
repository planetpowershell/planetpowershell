using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class SvenVanRijen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Sven";
        public string LastName => "van Rijen";
        public string ShortBioOrTagLine => "Senior Engineer, mainly working on (client) OS Deployment and Management.";
        public string StateOrRegion => "Wageningen, The Netherlands";
        public string TwitterHandle => "svenvanrijen";
        public string GitHubHandle => "svenvanrijen";
        public string GravatarHash => "b7735274c4f28b3e241a39fa61cb1d91";
        public GeoPosition Position => new GeoPosition(51.9691870, 5.6653950);

        public Uri WebSite => new Uri("https://www.svenvanrijen.nl");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.svenvanrijen.nl/feed.xml"); } }

        public bool Filter(SyndicationItem item)
        {

            // This filters out only the posts that have the "PowerShell" category
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));

        }
        public string FeedLanguageCode => "en";
    }
}
