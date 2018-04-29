using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class BoeProx : IAmAMicrosoftMVP
    {
        public string FirstName => "Boe";
        public string LastName => "Prox";
        public string ShortBioOrTagLine => "SQL DBA, Windows Admin, Security wannabe, who loves PowerShell";
        public string StateOrRegion => "Bellevue, NE";
        public string TwitterHandle => "proxb";
        public string GravatarHash => "3bde2094c84fb81661c04ed87f8336b7";
        public string GitHubHandle => "boeprox";
        public GeoPosition Position => new GeoPosition(41.15861, -95.93417);
        public Uri WebSite => new Uri("https://www.learn-powershell.net");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.learn-powershell.net/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}