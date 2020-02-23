using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
<<<<<<< HEAD
    public class RobSewell : IFilterMyBlogPosts
=======
    public class RobSewell : IAmAMicrosoftMVP, IFilterMyBlogPosts
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    {
        public string FirstName => "Rob";
        public string LastName => "Sewell";
        public string ShortBioOrTagLine => "is a PowerShell Bearded Fella and SQL Server DBA ";
        public string StateOrRegion => "Somerset, UK";
        public string EmailAddress => "";
        public string TwitterHandle => "sqldbawithbeard";
        public string GravatarHash => "bdbac4b4103fc16a37e87bd02945219f";

        public Uri WebSite => new Uri("https://sqldbawithabeard.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://sqldbawithabeard.com/feed/"); }
        }

        public string GitHubHandle => "sqldbawithabeard";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }

        public GeoPosition Position => new GeoPosition(50.952495, -3.267374);
<<<<<<< HEAD
    }
}
=======
        public string FeedLanguageCode => "en";
    }
}
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
