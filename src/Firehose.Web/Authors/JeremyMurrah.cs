using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JeremyMurrah : IAmACommunityMember
    {
        public string FirstName => "Jeremy";
        public string LastName => "Murrah";
        public string ShortBioOrTagLine => "A Windows Sysadmin turned automation engineer.  Passionate about PowerShell and automation in general";
        public string StateOrRegion => "TX, USA";
        public string TwitterHandle => "Jeremy Murrah";
        public string GitHubHandle => "murrahjm";
        public string GravatarHash => "297b54809ef14f5f3b8d0eb8e3c700f3";

        public GeoPosition Position => new GeoPosition(29.7602, -95.3694);

        public Uri WebSite => new Uri("https://murrahjm.github.io/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://murrahjm.github.io/feed.xml"); }
        }
        public string FeedLanguageCode => "en";
    }
}
