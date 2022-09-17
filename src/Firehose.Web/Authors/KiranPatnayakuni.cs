using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KiranPatnayakuni : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Kiran";
        public string LastName => "Patnayakuni";
        public string ShortBioOrTagLine => "Cloud Ops Engineering Specialist @ Accenture";
        public string StateOrRegion => "Karnataka, India";
        public string EmailAddress => "kiran@patnayakuni.com";
        public string TwitterHandle => "kpatnayakuni";
        public string GitHubHandle => "kpatnayakuni";
        public string GravatarHash => "9e6f3d364a0c54d745ff5c33ab4a8885";

        public GeoPosition Position => new GeoPosition(12.896208, 77.596138);

        public Uri WebSite => new Uri("https://kpatnayakuni.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://kpatnayakuni.com/index.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
        public string FeedLanguageCode => "en";
    }
}