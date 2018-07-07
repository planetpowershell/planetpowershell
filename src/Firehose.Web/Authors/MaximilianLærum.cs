using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class MaximilianLærum : IAmACommunityMember
    {
        public string FirstName => "Maximilian";
        public string LastName => "Lærum";
        public string ShortBioOrTagLine => "PowerShell enthusiast";
        public string StateOrRegion => "Norway";
        public string TwitterHandle => "tr4psec";
        public string GravatarHash => "0e45a9759e36d29ac45cf020882cdf5c";
        public string GitHubHandle => "Tr4pSec";
        public GeoPosition Position => new GeoPosition(59.4172096, 10.4834299);

        public Uri WebSite => new Uri("https://get-help.guru/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://get-help.guru/rss"); } }
        public string FeedLanguageCode => "en";
    }
}
