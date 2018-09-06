using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarkKraus : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "James";
        public string LastName => "Petty";
        public string ShortBioOrTagLine => "Windows Server Administrator, PowerShell enthusiast, PowerShell.org CFO";
        public string StateOrRegion => "Chattanooga, Tennessee, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "psjamesp";
        public string GitHubHandle => "psjamesp";
        public string GravatarHash => "a7f8b94204f4ca1e53c84aedc1242f8e";
        public GeoPosition Position => new GeoPosition(35.045631, ‎-85.309677);

        public Uri WebSite => new Uri("https://www.scriptautomaterepeat.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://scriptautomaterepeat.com/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}
