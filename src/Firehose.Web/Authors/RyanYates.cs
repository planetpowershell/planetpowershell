using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RyanYatesMVP : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "Ryan";
        public string LastName => "Yates";
        public string ShortBioOrTagLine => "is a Microsoft MVP, Consultant at Black Marble, Lead Coordinator for UK PowerShell User Groups.";
        public string StateOrRegion => "England, UK";
        public string EmailAddress => "ryan.yates@kilasuit.org";
        public string TwitterHandle => "ryanyates1990";
        public string GravatarHash => "3dfa95e0c1d6efa49d57dfd89010d0a7";

        public Uri WebSite => new Uri("https://blog.kilasuit.org/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.kilasuit.org/feed/"); }
        }

        public string GitHubHandle => "kilasuit";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("PowerShell", StringComparison.OrdinalIgnoreCase)).Any();
        }     
    }
}
