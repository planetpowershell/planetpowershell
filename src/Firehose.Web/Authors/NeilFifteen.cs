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
        public string ShortBioOrTagLine => "My adventures found in PowerShell...";
        public string StateOrRegion => "Cheltenham, England";
        public string EmailAddress => "neil@digitalfifteen.com";
        public string TwitterHandle => "neil_fifteen";
        public string GitHubHandle => "neilfifteen";
        public string GravatarHash => "68ffe557305106c5c399682b5c869cd7";
        public GeoPosition Position => new GeoPosition(51.897991, -2.071310);

        public Uri WebSite => new Uri("https://digitalfifteen.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://digitalfifteen.co.uk/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
