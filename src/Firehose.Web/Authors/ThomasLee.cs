using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThomasLee : IAmAMicrosoftMVP
    {
        public string FirstName => "Thomas";
        public string LastName => "Lee";
        public string ShortBioOrTagLine => "Just this guy, living in the UK. Grateful Dead fan, and long time PowerShell Fan. MVP 17 times";
        public string StateOrRegion => "Berkshire, UI";
        public string EmailAddress =>  "DoctorDNS@Gmail.Com";
        public string TwitterHandle => "DoctorDNS";
        public string GravatarHash => "9fac677a9811ddc033b9ec883606031d";
        public string GitHubHandle => "DoctorDNS";
        public GeoPosition Position => new GeoPosition(51.5566737,-0.6941204);
        public Uri WebSite => new Uri("https://tfl09.blogspot.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://tfl09.blogspot.com/feeds/posts/default/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
