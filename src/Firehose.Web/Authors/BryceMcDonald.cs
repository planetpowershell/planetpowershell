using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BryceMcDonald : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Bryce";
        public string LastName => "McDonald";
        public string ShortBioOrTagLine => "KC based PowerShell and Automation guru";
        public string StateOrRegion => "Kansas City, Missouri";
        public string TwitterHandle => "_brycemcdonald";
        public string GravatarHash => "e6600de53eef91dd803a6386c20a40bf";
        public string GitHubHandle => "mcdonaldbm";
        public GeoPosition Position => new GeoPosition(39.0997, -94.5786);
        public Uri WebSite => new Uri("https://www.brycematthew.net");
        public IEnumerable<Uri> FeedUris 
        {
            get { yield return new Uri("https://www.brycematthew.net/feed.xml"); } 
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
        public string FeedLanguageCode => "en";
    }
}
