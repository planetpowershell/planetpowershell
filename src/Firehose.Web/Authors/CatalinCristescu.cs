using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class CatalinCristescu : IAmACommunityMember
    {
        public string FirstName => "Catalin";
        public string LastName => "Cristescu";
        public string Pronouns => "He/Him";
        public string ShortBioOrTagLine => "Virtualization Engineer. Interested in VMWare, Windows, Powershell, Automation";
        public string StateOrRegion => "Timis, Romania";
        public string EmailAddress => "catalin@powershell.ro";
        public string TwitterHandle => "cristescu28";
        public string MastodonHandle => "";
        public string GravatarHash => "a7bbeab5380a2bbedb44b55fc28423db4aad7870666cc1e89b7a23f59535cd06";
        public Uri WebSite => new Uri("https://powershell.ro/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://powershell.ro/feed"); }
        }
        public string GitHubHandle => "cristescucatalin";
        public GeoPosition Position => new GeoPosition(45.691424,21.905853);
        public string FeedLanguageCode => "en";
    }
}
