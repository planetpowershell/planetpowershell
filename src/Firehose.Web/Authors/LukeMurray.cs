using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class LukeMurray : IAmACommunityMember
    {
        public string FirstName => "Luke";
        public string LastName => "Murray";
        public string ShortBioOrTagLine => "An IT Engineer with a love for all things IT including (but not limited to), Microsoft Azure, Automation and Service Management!";
        public string StateOrRegion => "Waikato, New Zealand";
        public string TwitterHandle => "lukemurraynz";
        public string GitHubHandle => "lukemurraynz";
        public string GravatarHash => "8ffb014d63a93e99033fca127fd14640";
        public GeoPosition Position => new GeoPosition(-37.45579900000001, 175.18940450000002);
        public Uri WebSite => new Uri("https://luke.geek.nz");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://luke.geek.nz/feed.category.powershell.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
