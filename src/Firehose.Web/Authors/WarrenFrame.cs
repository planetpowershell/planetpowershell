using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class WarrenFrame : IAmAMicrosoftMVP
    {
        public string FirstName => "Warren";
        public string LastName => "Frame";
        public string ShortBioOrTagLine => ":Infrastructure Engineer with a penchant for PowerShell, science, cooking, information security, family, cookies, and the Oxford comma.";
        public string StateOrRegion => "Boston Area, USA";
        public string EmailAddress => "warren.frame+pps@gmail.com";
        public string TwitterHandle => "pscookiemonster";
        public string GitHubHandle => "ramblingcookiemonster";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(42.3391000, -71.1206200);
        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2016, 1, 1);

        public Uri WebSite => new Uri("http://ramblingcookiemonster.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://ramblingcookiemonster.github.io/feed.xml"); } }
    }
}
