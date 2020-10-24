using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GuidoOliveira : IAmAMicrosoftMVP
    {
        public string FirstName => "Guido";
        public string LastName => "Oliveira";
        public string ShortBioOrTagLine => "Automation Engineer, Microsoft Azure Architect, Microsoft MVP,.";
        public string StateOrRegion => "Sao Paulo, BR";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "_Guido_Oliveira";
        public string GravatarHash => "c1246cb9e45ce18ade58f0a99ec0a106";
        public string GitHubHandle => "guidooliveira";
        public GeoPosition Position => new GeoPosition(23.4543,46.5337);
        public Uri WebSite => new Uri("https://www.guidooliveira.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.guidooliveira.com/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
