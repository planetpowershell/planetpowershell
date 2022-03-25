using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DarwinSanoy : IAmACommunityMember
    {
        public string FirstName => "Darwin";
        public string LastName => "Sanoy";
        public string ShortBioOrTagLine => "Village Cloudsmith - At The Flaming Forge Of The Cloud :)";
        public string StateOrRegion => "Philadelphia, PA";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "DarwinTheorizes";
        public string GravatarHash => "566be8d4a7b78dc25ab07bd61a48116b";
        public string GitHubHandle => "DarwinJS";
        public GeoPosition Position => new GeoPosition(40.1303822,-75.5149128);
        public Uri WebSite => new Uri("https://missionimpossiblecode.io");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://missionimpossiblecode.io/tags/powershell/index.xml"); }
        }
        public string FeedLanguageCode => "en";
    }
}
