using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class ChrisHunt : IAmACommunityMember
    {
        public string FirstName => "Chris";
        public string LastName => "Hunt";
        public string ShortBioOrTagLine => "Windows Platform Engineer. Co-organizer of Norther Virginia PowerShell User Group. I ❤️ data & testing.";
        public string StateOrRegion => "Northern Virginia, United States";
        public string TwitterHandle => "logicaldiagram";
        public string GravatarHash => "d5d9ccbefb9ee62169d1543d5634d0fd";

        public Uri WebSite => new Uri("https://www.automatedops.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.automatedops.com/index.xml"); }
        }

        public string GitHubHandle => "cdhunt";

        public GeoPosition Position => new GeoPosition(39.0913089, -77.5440391);
        public string FeedLanguageCode => "en";
    }
}