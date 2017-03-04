using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MukeshShende : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Mukesh";
        public string LastName => "Shende";
        public string ShortBioOrTagLine => "Technologist & Trainer";
        public string StateOrRegion => "Hyderabad";
        public string EmailAddress => "shendemukesh@hotmail.com";
        public string TwitterHandle => "mukeshshende";
        public string GravatarHash => "f3b1949e781cf05f10946a2a6e111353";
        public string GitHubHandle => "mukeshshende";
        public GeoPosition Position => new GeoPosition(17.375, 78.4744);

        public Uri WebSite => new Uri("http://mukeshshende.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mukeshnotes.wordpress.com/feed/"); } }
		
		public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("powershell"));
        }
    }
}