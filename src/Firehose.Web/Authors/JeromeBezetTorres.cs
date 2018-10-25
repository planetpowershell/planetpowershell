using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JM2K69 : IAmACommunityMember
    {
        public string FirstName => "Jerome";
        public string LastName => "Bezet-Torres";
        public string ShortBioOrTagLine => "Geek, Father, Trainer,MCT";
        public string StateOrRegion => "Lyon, FR";
        public string EmailAddress => "bezettorres.jerome@gmail.com";
        public string TwitterHandle => "JM2K69";
        public string GitHubHandle => "JM2K69";
        public string GravatarHash => "d1c4718717fd44b6577e071b73649882";
        public GeoPosition Position => new GeoPosition(45.750000, 4.850000);

        public Uri WebSite => new Uri("https://JM2K69.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://jm2k69.github.io/feed.xml"); } }
    }
}
