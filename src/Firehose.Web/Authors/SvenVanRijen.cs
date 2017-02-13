using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SvenVanRijen : IAmACommunityMember
    {
        public string FirstName => "Sven";
        public string LastName => "van Rijen";
        public string ShortBioOrTagLine => "Senior Engineer, mainly working on Infrastructure as Code and Azure.";
        public string StateOrRegion => "Wageningen, The Netherlands";
        public string EmailAddress => "sven@svenvanrijen.nl";
        public string TwitterHandle => "svenvanrijen";
        public string GitHubHandle => "svenvanrijen";
        public string GravatarHash => "b7735274c4f28b3e241a39fa61cb1d91";
        public GeoPosition Position => new GeoPosition(51.9691870, 5.6653950);

        public Uri WebSite => new Uri("http://www.svenvanrijen.nl");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.svenvanrijen.nl/feed.xml"); } }
    }
}
