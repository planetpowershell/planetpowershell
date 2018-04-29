using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class AlainAssaf : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Alain";
        public string LastName => "Alain";
        public string ShortBioOrTagLine => "Citrix Specialist at SECU - Citrix Technology Advocate - Feedspot Top 50 PowerShell Blogs on the web";
        public string StateOrRegion => "North Carolina, USA";
        public string TwitterHandle => "alainassaf";
        public string GitHubHandle => "alainassaf";
        public string GravatarHash => "55e3ac1ac8ca9129cc9e138a158b07bb";
        public GeoPosition Position => new GeoPosition(35.7795900, -78.6381790);
        public Uri WebSite => new Uri("https://wagthereal.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://wagthereal.com/feed"); } }
     
        public bool Filter(SyndicationItem item)
        {
            // this filters out posts that do not have PowerShell in the title
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
        public string FeedLanguageCode => "en";
    }
}
