using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class BrandonOlin : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Brandon";
        public string LastName => "Olin";
        public string ShortBioOrTagLine => "Cloud Architect and veteran Systems Engineer with a penchant for PowerShell, DevOps processes, and open-source software.";
        public string StateOrRegion => "Portland, Oregon";
        public string TwitterHandle => "devblackops";
        public string GitHubHandle => "devblackops";
        public string GravatarHash => "07f265f8f921b6876ce9ea65902f0480";
        public GeoPosition Position => new GeoPosition(45.5131063, -122.670492);
        public Uri WebSite => new Uri("https://devblackops.io/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://devblackops.io/feed.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
        public string FeedLanguageCode => "en";
    }

}
