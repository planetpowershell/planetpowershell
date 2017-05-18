using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DavidChristian : IAmACommunityMember
    {
        public string FirstName => "David";
        public string LastName => "Christian";
        public string ShortBioOrTagLine => "Father, DevOps Engineer, Musician, Dude";
        public string StateOrRegion => "Orange County, CA";
        public string EmailAddress => "dchristian3188@gmail.com";
        public string TwitterHandle => "dchristian3188";
        public string GitHubHandle => "dchristian3188";
        public string GravatarHash => "835bce5d3f5fbfbad3ac5ec42a6abad2";
        public GeoPosition Position => new GeoPosition(33.7174710,-117.8311430);

        public Uri WebSite => new Uri("http://overpoweredshell.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://overpoweredshell.com/feed.xml"); } }
    }
}
