using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class WarrenFrame : IAmAMicrosoftMVP
    {
        public string FirstName => "Warren";
        public string LastName => "Frame";
        public string ShortBioOrTagLine => ":Infrastructure Engineer with a penchant for PowerShell, science, cooking, information security, family, cookies, and the Oxford comma.";
        public string StateOrRegion => "Boston Area, USA";
        public string TwitterHandle => "pscookiemonster";
        public string GitHubHandle => "ramblingcookiemonster";
        public string GravatarHash => "a8fe2612cd3466787b0a7a99889f5901";
        public GeoPosition Position => new GeoPosition(42.3391000, -71.1206200);

        public Uri WebSite => new Uri("https://ramblingcookiemonster.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ramblingcookiemonster.github.io/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
