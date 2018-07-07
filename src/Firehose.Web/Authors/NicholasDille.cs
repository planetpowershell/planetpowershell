using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class NicholasDille : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "Nicholas";
        public string LastName => "Dille";
        public string ShortBioOrTagLine => "and Docker Captain. He is focused on Infrastructure-as-Code, Containers, PowerShell and Cross-Platform";
        public string StateOrRegion => "Freiburg, Germany";
        public string TwitterHandle => "nicholasdille";
        public string GravatarHash => "3abbda431b19f55e29a1494b1fb3b859";

        public Uri WebSite => new Uri("https://dille.name");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://dille.name/feed.xml"); }
        }

        public string GitHubHandle => "nicholasdille";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }

        public GeoPosition Position => new GeoPosition(47.9874048, 7.7263806);
        public string FeedLanguageCode => "en";
    }
}
