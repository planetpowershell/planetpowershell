using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KieranJacobsen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Kieran";
        public string LastName => "Jacobsen";
        public string ShortBioOrTagLine => "Readifarian, works with PowerShell";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "code@poshsecurity.com";
        public string TwitterHandle => "kjacobsen";
        public string GravatarHash => "";

        public Uri WebSite => new Uri("https://poshsecurity.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://poshsecurity.com/blog/?format=rss"); }
        }

        public string GitHubHandle => "kjacobsen";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("code"));
        }

        public GeoPosition Position => new GeoPosition(43.8938256, 18.3129519);
    }
}