using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class NeilFifteen : IAmACommunityMember
    {
        public string FirstName => "Neil";
        public string LastName => "Fifteen";
        public string ShortBioOrTagLine => "PowerShell, Whiskey, Buttons and Wires.";
        public string StateOrRegion => "Ashleworth, England";
        public string EmailAddress => "neil@digitalfifteen.com";
        public string TwitterHandle => "digitalfifteen";
        public string GitHubHandle => "digitalfifteen";
        public string GravatarHash => "0e3cb9812dc19014dfbb000a7953b764";
        public GeoPosition Position => new GeoPosition(51.930364, -2.274356);

        public Uri WebSite => new Uri("https://digitalfifteen.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://digitalfifteen.co.uk/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
