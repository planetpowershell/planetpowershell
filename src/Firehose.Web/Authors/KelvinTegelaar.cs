using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KelvinTegelaar : IAmACommunityMember
    {
        public string FirstName => "Kelvin";
        public string LastName => "Tegelaar";
        public string ShortBioOrTagLine => "For every monitoring automation there is an equal PowerShell remediation.";
        public string StateOrRegion => "Rotterdam, Netherlands";
        public string EmailAddress => "ktegelaar@cyberdrain.com";
        public string TwitterHandle => "KelvinTegelaar";
        public string MastodonHandle => "";
        public string GitHubHandle => "KelvinTegelaar";
        public string GravatarHash => "4dc012d6848c8403805130f2fefcf64b";
        public GeoPosition Position => new GeoPosition(51.921638,4.528056);
        public Uri WebSite => new Uri("https://www.cyberdrain.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.cyberdrain.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
