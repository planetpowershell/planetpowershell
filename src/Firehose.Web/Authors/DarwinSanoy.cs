using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class DarwinSanoy : IAmACommunityMember
    {
        public string FirstName => "Darwin";
        public string LastName => "Sanoy";
        public string ShortBioOrTagLine => "Cloudifying Windows Everyday";
        public string StateOrRegion => "Phoenixville, PA";
        public string TwitterHandle => "DarwinTheorizes";
        public string GravatarHash => "566be8d4a7b78dc25ab07bd61a48116b";
        public string GitHubHandle => "DarwinJS";
        public GeoPosition Position => new GeoPosition(40.1303822,-75.5149128);
        public Uri WebSite => new Uri("https://cloudywindows.io");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://cloudywindows.io/tags/powershell/index.xml"); }
        }
        public string FeedLanguageCode => "en";
    }
}
