using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class MarkKraus : IAmACommunityMember
    {
        public string FirstName => "Mark";
        public string LastName => "Kraus";
        public string ShortBioOrTagLine => "IT Solutions Architect, PowerShell enthusiast";
        public string StateOrRegion => "Dallas/Fort Worth, Texas, USA";
        public string TwitterHandle => "markekraus";
        public string GitHubHandle => "markekraus";
        public string GravatarHash => "ddd9a3f6a4c31ea3c3a214b5f0912c36";
        public GeoPosition Position => new GeoPosition(32.9481800,-96.7297200);

        public Uri WebSite => new Uri("https://get-powershellblog.blogspot.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://get-powershellblog.blogspot.com/feeds/posts/default"); } }
        public string FeedLanguageCode => "en";
    }
}
