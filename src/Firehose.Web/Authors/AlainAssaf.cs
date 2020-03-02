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
        public string LastName => "Alain";
        public string ShortBioOrTagLine => "Citrix Specialist at SECU - Citrix Technology Advocate - Feedspot Top 50 PowerShell Blogs on the web";
        public string StateOrRegion => "North Carolina, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "alainassaf";
        public string GitHubHandle => "alainassaf";
        public string GravatarHash => "55e3ac1ac8ca9129cc9e138a158b07bb";
        public GeoPosition Position => new GeoPosition(35.7795900, -78.6381790);
        public Uri WebSite => new Uri("https://alainassaf.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://alainassaf.github.io/feed"); } }
     	public string FeedLanguageCode => "en";
    }
}
