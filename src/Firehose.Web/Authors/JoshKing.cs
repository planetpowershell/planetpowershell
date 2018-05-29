using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JoshKing : IAmACommunityMember
    {
        public string FirstName => "Josh";
        public string LastName => "King";
        public string ShortBioOrTagLine => "Geek, Father, Walking Helpdesk";
        public string StateOrRegion => "Hawke's Bay, NZ";
        public string TwitterHandle => "WindosNZ";
        public string GitHubHandle => "Windos";
        public string GravatarHash => "fafdbc410c9adf8c4d2235d37470859a";
        public GeoPosition Position => new GeoPosition(-39.4928, 176.9120);

        public Uri WebSite => new Uri("https://king.geek.nz/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://king.geek.nz/tag/powershell/rss/"); } }
        public string FeedLanguageCode => "en";
    }
}
