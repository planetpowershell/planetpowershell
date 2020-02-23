using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AaronNelson : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Aaron";
        public string LastName => "Nelson";
        public string ShortBioOrTagLine => "Microsoft SQL Server (Data Platform) MVP and leader of the PowerShell Virtual Group of PASS";
        public string StateOrRegion => "Georgia, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "SQLvariant";
        public string GitHubHandle => "SQLvariant";
        public string GravatarHash => "2b18aa0a254cd01e09918c4b24274e21";
        public GeoPosition Position => new GeoPosition(34.058389, -84.286303);
<<<<<<< HEAD
        public Uri WebSite => new Uri("http://SQLvariant.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://feeds.feedburner.com/Sqlvariations"); } }
=======
        public Uri WebSite => new Uri("https://SQLvariant.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds.feedburner.com/Sqlvariations"); } }
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
<<<<<<< HEAD
=======
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
