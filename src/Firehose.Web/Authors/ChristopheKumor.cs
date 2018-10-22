using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class FrancoisxavierCat : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Christophe";
        public string LastName => "Kumor";
        public string ShortBioOrTagLine => "Systems Engineer, French PowerShell UserGroup Member";
        public string StateOrRegion => "France";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "ChristopheKumor";
        public string GitHubHandle => "christophekumor";
        public string GravatarHash => "577ca07fd4a83e8ee441226dfe56e000";
        public GeoPosition Position => new GeoPosition(50.633331,3.06667);
 
        public Uri WebSite => new Uri("https://christophekumor.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://christophekumor.github.io/feed.xml"); } }
         
        public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}
