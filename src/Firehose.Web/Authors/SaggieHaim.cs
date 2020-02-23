using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class SaggieHaim : IAmACommunityMember
    {
        public string FirstName => "Saggie";
        public string LastName => "Haim";
        public string ShortBioOrTagLine => "Blogging about powershell and automation";
        public string StateOrRegion => "Israel";
        public string EmailAddress => "contact@saggiehaim.net";
        public string TwitterHandle => "saggiehaim";
        public string GravatarHash => "933957374d006887d1ac1928e1a02a48";
        public string GitHubHandle => "SaggieHaim";
        public GeoPosition Position => new GeoPosition(32.0853, 34.7818);

        public Uri WebSite => new Uri("https://www.saggiehaim.net//");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.saggiehaim.net/feed/"); } }
        // Filter for Powershell Posts
        public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}
