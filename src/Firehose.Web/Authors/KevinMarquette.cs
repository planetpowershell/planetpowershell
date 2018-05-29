using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class KevinMarquette : IAmACommunityMember
    {
        public string FirstName => "Kevin";
        public string LastName => "Marquette";
        public string ShortBioOrTagLine => "Sr. DevOps Engineer. Powershell all the things!";
        public string StateOrRegion => "Orange County, USA";
        public string TwitterHandle => "kevinmarquette";
        public string GitHubHandle => "kevinmarquette";
        public string GravatarHash => "d7d29e9573b5da44d9886df24fcc6142";
        public GeoPosition Position => new GeoPosition(33.6800000,-117.7900000);

        public Uri WebSite => new Uri("https://kevinmarquette.github.io");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://kevinmarquette.github.io/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
