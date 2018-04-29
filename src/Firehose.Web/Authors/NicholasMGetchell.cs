using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class NicholasMGetchell : IAmACommunityMember
    {
        public string FirstName => "Nicholas";
        public string LastName => "Getchell";
        public string ShortBioOrTagLine => "Analyst";
        public string StateOrRegion => "Boston, MA";
        public string TwitterHandle => "getch3028";
        public string GravatarHash => "1ebff516aa68c1b3bc786bd291b8fca1";
        public string GitHubHandle => "ngetchell";
        public GeoPosition Position => new GeoPosition(53.073635, 8.806422);

        public Uri WebSite => new Uri("https://powershell.getchell.org");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://powershell.getchell.org/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
