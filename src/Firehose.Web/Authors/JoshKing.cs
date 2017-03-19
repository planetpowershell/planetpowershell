using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JoshKing : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Josh";
        public string LastName => "King";
        public string ShortBioOrTagLine => "Geek, Father, Walking Helpdesk";
        public string StateOrRegion => "Hawke's Bay, NZ";
        public string EmailAddress => "joshua@king.geek.nz";
        public string TwitterHandle => "WindosNZ";
        public string GitHubHandle => "Windos";
        public string GravatarHash => "fafdbc410c9adf8c4d2235d37470859a";
        public GeoPosition Position => new GeoPosition(-39.4928, 176.9120);

        public Uri WebSite => new Uri("http://king.geek.nz/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://king.geek.nz/feed.xml"); } }
		
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
    }
}
