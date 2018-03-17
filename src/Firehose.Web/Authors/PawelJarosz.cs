using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PawelJarosz : IAmACommunityMember
    {
        public string FirstName => "Pawel";
        public string LastName => "Jarosz";
        public string ShortBioOrTagLine => "My IT adventures with a doze of homour";
        public string StateOrRegion => "Wroclaw, Poland";
        public string EmailAddress => "pawel.jarosz@gmail.com";
        public string TwitterHandle => "PaweJarosz4";
        public string GitHubHandle => "zaicnupagadi";
        public string GravatarHash => "618ea542b42ec5910fa41f5454055811";
        public GeoPosition Position => new GeoPosition(51.1078850,17.0385380);

        public Uri WebSite => new Uri("https://paweljarosz.wordpress.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://paweljarosz.wordpress.com/feed/"); } }
    }
}
