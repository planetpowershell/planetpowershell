using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class BrandonPadgett : IAmAMicrosoftMVP
    {
        public string FirstName => "Brandon";
        public string LastName => "Padgett";
        public string ShortBioOrTagLine => "Proud Father and Microsoft MVP";
        public string StateOrRegion => "Murfreesboro, Tennessee";
        public string TwitterHandle => "BrandonPadgett";
        public string GitHubHandle => "gerane";
        public string GravatarHash => "b692ff1f3cec3583cafbf3fbba5cbadf";
        public GeoPosition Position => new GeoPosition(35.8449277, -86.3934149);

        public Uri WebSite => new Uri("http://brandonpadgett.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://brandonpadgett.com/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }

}
