using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class FarisMalaeb : IAmACommunityMember
    {
        public string FirstName => "Faris";
        public string LastName => "Malaeb";
        public string ShortBioOrTagLine => "System Automation and integration using PowerShell";
        public string StateOrRegion => "Abu Dhabi";
        public string EmailAddress => "farismalaeb@protonmail.com";
        public string TwitterHandle => "FarisMalaeb";
        public string GravatarHash => "377a1010f17e8d5c5564258012063655";
        public string GitHubHandle => "farismalaeb";
        public GeoPosition Position => new GeoPosition(24.471011, 54.378537);

        public Uri WebSite => new Uri("https://powershellcenter.com/");
		
		public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.powershellcenter.com/feed"); }
        }
        public string FeedLanguageCode => "en";
    }
}
