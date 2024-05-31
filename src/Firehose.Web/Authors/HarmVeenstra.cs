using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class HarmVeenstra : IAmAMicrosoftMVP
    {
        public string FirstName => "Harm";
        public string LastName => "Veenstra";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Microsoft MVP in PowerShell / Consultant at NEXXT (Https://www.nexxt.one)";
        public string StateOrRegion => "Overijssel";
        public string EmailAddress => "harm.veenstra@gmail.com";
        public string TwitterHandle => "HarmVeenstra";
        public string MastodonHandle => "@HarmVeenstra@mastodon.social";
        public string GravatarHash => "432c4a0a81ea2b900a6d654452002964";
        public string GitHubHandle => "HarmVeenstra";
        public GeoPosition Position => new GeoPosition(52.786708, 6.116538);

        public Uri WebSite => new Uri("https://powershellisfun.com/");
		
		public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://powershellisfun.com//feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
