using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JaapBrasser : IAmAMicrosoftMVP
    {
        public string FirstName => "Jaap";
        public string LastName => "Brasser";
        public string ShortBioOrTagLine => "Blogging about anything shiny and automation related, pretending to know PowerShell";
        public string StateOrRegion => "Amsterdam, Netherlands";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "jaap_brasser";
        public string GravatarHash => "dc8d4d1ec3179e966ccdd959aa16d11c";
        public string GitHubHandle => "jaapbrasser";
        public GeoPosition Position => new GeoPosition(52.635340, 4.885695);
        public Uri WebSite => new Uri("http://www.jaapbrasser.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.jaapbrasser.com/category/powershell/feed/"); }
        }
    }
}