using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
<<<<<<< HEAD
    public class JoshKing : IAmACommunityMember, IFilterMyBlogPosts
=======
    public class JoshKing : IAmACommunityMember
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
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
<<<<<<< HEAD

        public Uri WebSite => new Uri("https://king.geek.nz/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://king.geek.nz/feed.xml"); } }
		
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
=======
        public Uri WebSite => new Uri("https://toastit.dev/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://toastit.dev/tag/powershell/rss/"); } }
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
