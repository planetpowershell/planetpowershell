using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MikeKanakos : IAmAMicrosoftMVP
    {
        public string FirstName => "Mike";
        public string LastName => "Kanakos";
        public string Pronouns => "";
        public string ShortBioOrTagLine => " A Microsoft MVP and Automation enthusiast located in the RTP area of North Carolina. His blog concentrates on PowerShell and Azure automation.";
        public string StateOrRegion => "Apex, NC";
        public string EmailAddress => "mkanakos@gmail.com";
        public string TwitterHandle => "MikeKanakos";
        public string MastodonHandle => "";
        public string GravatarHash => "2bca167386e229ec2c5606f6c1677493";
        public string GitHubHandle => "compwiz32";
        public GeoPosition Position => new GeoPosition(35.7327, 78.8503);
        public Uri WebSite => new Uri("https://commandline.ninja");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://commandline.ninja/index.xml"); } }
		public string FeedLanguageCode => "en";
    }
}
