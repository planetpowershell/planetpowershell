using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
public class GuillaumeBlin : IAmACommunityMember
    {
        public string FirstName => "Guillaume";
        public string LastName => "Blin";
        public string Pronouns => "he/him";
        public string ShortBioOrTagLine => "Freelance trainer and PowerShell Addict";
        public string StateOrRegion => "France";
        public string EmailAddress => string.Empty;
        public string MastodonHandle => "@altf4formation@mastodon.social";
        public string TwitterHandle => "Altf4Formation";
        public string GravatarHash => "bf5fcc0578334f1c5d2d96ee5e42c977b537c3502bd71459844d6746251666df";
        public string GitHubHandle => "Guillaume-blin";
        public GeoPosition Position => new GeoPosition(47.2145, -1.5512);

        public Uri WebSite => new Uri("https://www.altf4-formation.fr/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.altf4-formation.fr/en/powershell-en.xml"); } }
    }
}
