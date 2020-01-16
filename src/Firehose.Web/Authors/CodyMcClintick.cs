using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class CodyMcClintick : IAmACommunityMember
    {
        public string FirstName => "Cody";
        public string LastName => "McClintick";
        public string ShortBioOrTagLine => "Azure Cloud Architect with an Identity Management Focus";
        public string StateOrRegion => "Pittsburgh, PA USA";
        public string EmailAddress => "cody@thelazyadmin.club";
        public string TwitterHandle => "thel4zyadm1n";
        public string GitHubHandle => "regretsi";
        public string GravatarHash => "655724f70fc4a687ed5d19a2e31d226e";
        public GeoPosition Position => new GeoPosition(40.88328170776367,-80.24375915527344);
        public Uri WebSite => new Uri("https://www.thelazyadmin.club");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.thelazyadmin.club/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
