using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class MikeFRobbins : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Mike";
        public string LastName => "Robbins";
<<<<<<< HEAD
        public string ShortBioOrTagLine => "Microsoft PowerShell MVP and SAPIEN Technologies MVP. Leader & Co-founder of MSPSUG";
=======
        public string ShortBioOrTagLine => "is the leader and co-founder of the Mississippi PowerShell User Group.";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public string StateOrRegion => "Mississippi, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "mikefrobbins";
        public string GitHubHandle => "mikefrobbins";
        public string GravatarHash => "e809f9f3d1f46f219c3a28b2fd7dbf83";
        public GeoPosition Position => new GeoPosition(32.3643100, -88.7036560);

<<<<<<< HEAD
        public Uri WebSite => new Uri("http://mikefrobbins.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://mikefrobbins.com/feed/"); } }
=======
        public Uri WebSite => new Uri("https://mikefrobbins.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mikefrobbins.com/feed/"); } }
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