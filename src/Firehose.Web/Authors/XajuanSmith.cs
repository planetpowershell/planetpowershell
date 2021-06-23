using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class XajuanSmith : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Xajuan";
        public string LastName => "Smith";
        public string ShortBioOrTagLine => "is a PowerShell Evangelist, Senior Enterprise Consultant at Coretek Services.";
        public string StateOrRegion => "Michigan, US";
        public string EmailAddress => "Xajuan@live.com";
        public string TwitterHandle => "XajuanS1";
        public string GravatarHash => "9084467aac5841fa7977fa8cafae76c4";
        public GeoPosition Position => new GeoPosition(44.182205, -84.506836);
        public Uri WebSite => new Uri("https://Powershell.city/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri(" https://powershell.city/feed/"); }
        }
        public string GitHubHandle => "XajuanXBTS";
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
