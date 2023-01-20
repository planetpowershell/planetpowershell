using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class PrzemyslawKlys : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Przemyslaw";
        public string LastName => "Klys";
        public string ShortBioOrTagLine => "Systems Architect, Software Geek";
        public string StateOrRegion => "Katowice, Poland";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "PrzemyslawKlys";
        public string MastodonHandle => "";
        public string GitHubHandle => "PrzemyslawKlys";
        public string GravatarHash => "f855c203fffaae0e1c1f16f4411236bf";
        public GeoPosition Position => new GeoPosition(50.2648919,19.0237815);
 
        public Uri WebSite => new Uri("https://evotec.xyz/hub/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://evotec.xyz/feed/"); } }
        
        public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
