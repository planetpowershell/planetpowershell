using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanFranciscus : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Dan";
        public string LastName => "Franciscus";
        public string ShortBioOrTagLine => "Sysadmin, PowerShell and Chocolatey evangelist, Blogger";
        public string StateOrRegion => "Belle Mead, New Jersey";
        public string EmailAddress => "dfranciscus@gmail.com";
        public string TwitterHandle => "dan_franciscus";
        public string GravatarHash => "c99c2eda81dc29f5b8adaf625e4db414";
<<<<<<< HEAD

        public Uri WebSite => new Uri("https://winsysblog.com/");

=======
        public Uri WebSite => new Uri("https://winsysblog.com/");
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://winsysblog.com/feed/"); }
        }
<<<<<<< HEAD

        public string GitHubHandle => "dfranciscus";

=======
        public string GitHubHandle => "dfranciscus";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
<<<<<<< HEAD

        public GeoPosition Position => new GeoPosition(40.462445, 74.6744);
=======
        public GeoPosition Position => new GeoPosition(40.462445, 74.6744);
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
