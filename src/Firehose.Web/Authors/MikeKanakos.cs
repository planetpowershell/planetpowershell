using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class MikeKanakos : IAmACommunityMember
    {
        public string FirstName => "Mike";
        public string LastName => "Kanakos";
        public string ShortBioOrTagLine => "Windows IT pro located in the RTP area of North Carolina. Active Directory, Azure AD, Group Policy, and automation.";
        public string StateOrRegion => "Apex, NC";
        public string EmailAddress => "mike@networkadm.in";
        public string TwitterHandle => "MikeKanakos";
        public string GravatarHash => "2bca167386e229ec2c5606f6c1677493";
        public string GitHubHandle => "compwiz32";
        public GeoPosition Position => new GeoPosition(35.7327, 78.8503);

        public Uri WebSite => new Uri("https://www.networkadm.in/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.networkadm.in/rss/"); } }
        public string FeedLanguageCode => "en";
    }
}
