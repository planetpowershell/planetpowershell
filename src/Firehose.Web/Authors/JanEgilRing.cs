using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JanEgilRing : IAmAMicrosoftMVP
    {
        public string FirstName => "Jan Egil";
        public string LastName => "Ring";
        public string ShortBioOrTagLine => "Microsoft MVP - Cloud & Datacenter Management";
        public string StateOrRegion => "Norway";
        public string TwitterHandle => "JanEgilRing";
        public string GitHubHandle => "janegilring";
        public string GravatarHash => "ed08d635415486b87539a6e5a81982b7";
        public GeoPosition Position => new GeoPosition(59.8832270,10.9551500);

        public Uri WebSite => new Uri("https://www.powershell.no");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.powershell.no/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }

}
