using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class FrancisSetash : IAmACommunityMember
    {
        public string FirstName => "Francis";
        public string LastName => "Setash";
        public string ShortBioOrTagLine => "i-py.com";
        public string StateOrRegion => "Arnold, MD";
        public string EmailAddress => "Francis@i-py.com";
        public string TwitterHandle => "";
        public string GravatarHash => "";
        public string GitHubHandle => "walked";
        public GeoPosition Position => new GeoPosition(39.0589050,-76.4910090);

        public Uri WebSite => new Uri("https://i-py.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://i-py.com/feed.xml"); } }
    }
    
    public bool Filter(SyndicationItem item)
    {
      return item.Title.Text.ToLowerInvariant().Contains("powershell");
    }
}

