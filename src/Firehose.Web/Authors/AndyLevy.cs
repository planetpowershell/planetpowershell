using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AndyLevy : IAmACommunityMember
    {
        public string FirstName => "Andy";
        public string LastName => "Levy";
        public string ShortBioOrTagLine => "DBA & PowerShell fan in New York's Wine Region";
        public string StateOrRegion => "New York";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "alevyinroc";
        public string GravatarHash => "6a2838f9f6d7e95c1124d4a301a1ae0d";
        public string GitHubHandle => "andylevy";
        public GeoPosition Position => new GeoPosition(42.8875, -77.281667);

        public Uri WebSite => new Uri("https://flxsql.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://flxsql.com/category/powershell/feed/"); } }

        }
    }
}
