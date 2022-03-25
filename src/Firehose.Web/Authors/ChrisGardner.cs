using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChrisGardner : IAmAMicrosoftMVP
    {
        public string FirstName => "Chris";
        public string LastName => "Gardner";
        public string ShortBioOrTagLine => "General tech nerd spending too much time in PowerShell.";
        public string StateOrRegion => "Yorkshire, UK";
        public string EmailAddress => "halbaradkenafin@outlook.com";
        public string TwitterHandle => "halbaradkenafin";
        public string GravatarHash => "0fb1b268e36194d977d56e778d5794a2";
        public string GitHubHandle => "chrislgardner";
        public GeoPosition Position => new GeoPosition(53.8008,-1.5491);
        public Uri WebSite => new Uri("https://chrislgardner.github.io");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://chrislgardner.github.io/feed.xml"); }
        }
        public string FeedLanguageCode => "en";
    }
}
