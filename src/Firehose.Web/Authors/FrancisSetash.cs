using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class FrancisSetash : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Francis";
        public string LastName => "Setash";
        public string ShortBioOrTagLine => "Infrastructure and DevOps Engineer. Lots of working with Chef, and PowerShell DSC";
        public string StateOrRegion => "Arnold, MD";
        public string TwitterHandle => "";
        public string GravatarHash => "0959b63fb022ccbc7eb47ad472ed5dad";

        public Uri WebSite => new Uri("https://i-py.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://i-py.com/feed.xml"); }
        }

        public string GitHubHandle => "walked";

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }

        public GeoPosition Position => new GeoPosition(39.0589050,-76.49100906);
        public string FeedLanguageCode => "en";
    }
}
