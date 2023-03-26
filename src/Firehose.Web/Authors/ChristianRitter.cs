 using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChristianRitter : IAmACommunityMember
    {
        public string FirstName => "Christian";
        public string LastName => "Ritter";
        public string Pronouns => "He/Him";
        public string ShortBioOrTagLine => "System Engineer with a PowerShell affinity";
        public string StateOrRegion => "Frankfurt a.M., Germany";
        public string EmailAddress => "H.christian.ritter@gmail.com";
        public string TwitterHandle => "blackboxcoder";
        public string MastodonHandle => "";
        public string GravatarHash => "fc1ea44b38f62d6fc6db0a52b66918aa ";
        public Uri WebSite => new Uri("https://hcritter.devdojo.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://devdojo.com/feed/hcritter"); }
        }
        public string GitHubHandle => "hcritter";
        public GeoPosition Position => new GeoPosition(50.110924,8.682127);
        public string FeedLanguageCode => "en";
    }
}
