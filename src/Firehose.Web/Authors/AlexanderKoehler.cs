using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AlexanderKoehler : IAmACommunityMember
    {
        public string FirstName => "Alexander";
        public string LastName => "Koehler";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "father,system engineer, automation guy, powershell enthusiast";
        public string StateOrRegion => "Mengen, Germany";
        public string EmailAddress => "planetpowershell@it-koehler.com";
        public string TwitterHandle => "ACharburner";
        public string MastodonHandle => "";
        public string GravatarHash => "bc09e87a59be038b93da1e03079aa053";
        public string GitHubHandle => "blog-it-koehler-com";
        public GeoPosition Position => new GeoPosition(48.03849438437253, 9.326946932715074);

        public Uri WebSite => new Uri("https://blog.it-koehler.com/en");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.it-koehler.com/en/feed"); } }
		public string FeedLanguageCode => "en";
    }
}
