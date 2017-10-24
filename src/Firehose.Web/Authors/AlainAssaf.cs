using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AlainAssaf : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Alain";
        public string LastName => "Assaf";
        public string ShortBioOrTagLine => "Citrix Specialist at SECU - Citrix Technology Advocate - Feedspot Top 50 PowerShell Blogs on the web";
        public string StateOrRegion => "North Carolina, USA";
        public string EmailAddress => "alainassaf@outlook.com";
        public string TwitterHandle => "alainassaf";
        public string GitHubHandle => "alainassaf";
        public GeoPosition Position => new GeoPosition(35.7795900, -78.6381790);
        public Uri WebSite => new Uri("https://wagthereal.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://wagthereal.com/feed/"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}
