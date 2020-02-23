using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DavidOBrien : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "David";
        public string LastName => "O'Brien";
        public string ShortBioOrTagLine => "is a Microsoft MVP, DevOps Consultant/Engineer, do AWS and a lot of Cloud.";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "me@david-obrien.net";
        public string TwitterHandle => "david_obrien";
        public string GravatarHash => "c93bbf72255d38bab70895eb7c0b3f99";
<<<<<<< HEAD

        public Uri WebSite => new Uri("https://david-obrien.net/");

=======
        public Uri WebSite => new Uri("https://david-obrien.net/");
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://david-obrien.net/feed.xml"); }
        }
<<<<<<< HEAD

        public string GitHubHandle => "davidobrien1985";

=======
        public string GitHubHandle => "davidobrien1985";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
<<<<<<< HEAD

        public GeoPosition Position => new GeoPosition(-37.8136,144.9631);       
=======
        public GeoPosition Position => new GeoPosition(-37.8136,144.9631);
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}