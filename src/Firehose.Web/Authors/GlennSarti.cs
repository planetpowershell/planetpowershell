using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
<<<<<<< HEAD
    public class GlennSarti : IFilterMyBlogPosts
=======
    public class GlennSarti : IAmACommunityMember, IFilterMyBlogPosts
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    {
        public string FirstName => "Glenn";
        public string LastName => "Sarti";
        public string ShortBioOrTagLine => "is a Windows Software and Infrastructure Developer for Puppet.";
        public string StateOrRegion => "Portland OR, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "glennsarti";
        public string GravatarHash => "aac3dafaab7a7c2063d2526ba5936305";
<<<<<<< HEAD

        public Uri WebSite => new Uri("http://glennsarti.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://glennsarti.github.io/feed.xml"); }
        }

        public string GitHubHandle => "glennsarti";

=======
        public Uri WebSite => new Uri("https://glennsarti.github.io/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://glennsarti.github.io/feed.xml"); }
        }
        public string FeedLanguageCode => "en";
        public string GitHubHandle => "glennsarti";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
<<<<<<< HEAD

        public GeoPosition Position => new GeoPosition(45.5234500,-122.6762100);
    }
}
=======
        public GeoPosition Position => new GeoPosition(45.5234500,-122.6762100);
    }
}
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
