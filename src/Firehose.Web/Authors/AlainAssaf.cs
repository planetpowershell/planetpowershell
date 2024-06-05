using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AlainAssaf : IAmACommunityMember
    {
        public string FirstName => "Alain";
        public string LastName => "Assaf";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Automation Engineer | PowerShell Fanatic | Cloud Novice | EUC Architect | CUGC Leader | Citrix CTA | CCE-V Certified";
        public string StateOrRegion => "North Carolina, USA";
        public string EmailAddress => "alainassaf@outlook.com";
        public string TwitterHandle => "alainassaf";
        public string MastodonHandle => "";
        public string GitHubHandle => "alainassaf";
        public string GravatarHash => "55e3ac1ac8ca9129cc9e138a158b07bb";
        public GeoPosition Position => new GeoPosition(35.7795900, -78.6381790);
        public Uri WebSite => new Uri("https://alainassaf.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://alainassaf.com/feed.xml"); } }
		public string FeedLanguageCode => "en";
	}
}
