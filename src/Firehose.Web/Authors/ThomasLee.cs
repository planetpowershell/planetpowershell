using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThomasLee : IAmACommunityMember
    {
        public string FirstName => "Thomas";
        public string LastName => "Lee";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Just this guy, living in the UK. A Grateful Dead and long time PowerShell Fan. MVP 17 times";
        public string StateOrRegion => "Berkshire, UK";
        public string EmailAddress =>  "DoctorDNS@Gmail.Com";
        public string TwitterHandle => "DoctorDNS";
        public string MastodonHandle => "@DoctorDNS@Masto.AI";
        public string GravatarHash => "9fac677a9811ddc033b9ec883606031d";
        public string GitHubHandle => "DoctorDNS";
        public GeoPosition Position => new GeoPosition(51.5566737,-0.6941204);
        public Uri WebSite => new Uri("https://tfl09.blogspot.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://tfl09.blogspot.com/feeds/posts/default?alt=rss"); }
        }
        public string FeedLanguageCode => "en";
    }
}
