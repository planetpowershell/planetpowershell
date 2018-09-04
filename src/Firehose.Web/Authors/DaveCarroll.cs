using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DaveCarroll : IAmACommunityMember
    {
        public string FirstName => "Dave";
        public string LastName => "Carroll";
        public string ShortBioOrTagLine => "Systems engineer with a strong predilection for automation.";
        public string StateOrRegion => "Nashville, TN";
        public string EmailAddress => "";
        public string TwitterHandle => "thedavecarroll";
        public string GitHubHandle => "thedavecarroll";
        public string GravatarHash => "fd0387e212af38089603b5480e406545";
        public GeoPosition Position => new GeoPosition(36.0679, -86.7194);

        public Uri WebSite => new Uri("https://powershell.anovelidea.org/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://powershell.anovelidea.org/feed.xml"); } }


    }
}