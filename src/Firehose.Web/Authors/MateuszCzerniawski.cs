using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MateuszCzerniawski : IAmAMicrosoftMVP
    {
        public string FirstName => "Mateusz";
        public string LastName => "Czerniawski";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "PowerShell Enthusiast, WinOps and HyperV";
        public string StateOrRegion => "Wroclaw, Poland";
        public string EmailAddress => "mczerniawski@arcon.net.pl";
        public string TwitterHandle => "arcontar";
        public string MastodonHandle => "";
        public string GitHubHandle => "mczerniawski";
        public string GravatarHash => "f0e6c49009d0a9fb3c1453c2cfd9334a";
        public GeoPosition Position => new GeoPosition(51.1078850,17.0385380);
        public Uri WebSite => new Uri("https://www.mczerniawski.pl");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.mczerniawski.pl/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}