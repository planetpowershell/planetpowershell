using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GlennSarti : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Glenn";
        public string LastName => "Sarti";
        public string ShortBioOrTagLine => "is a Senior Software Developer for HashiCorp.";
        public string StateOrRegion => "Perth, Australia";
        public string EmailAddress => "";
        public string TwitterHandle => "glennsarti";
        public string GravatarHash => "aac3dafaab7a7c2063d2526ba5936305";
        public Uri WebSite => new Uri("https:/sarti.dev/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://sarti.dev/feed.xml"); }
        }
        public string FeedLanguageCode => "en";
        public string GitHubHandle => "glennsarti";
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public GeoPosition Position => new GeoPosition(-31.9523,115.8613);
    }
}
