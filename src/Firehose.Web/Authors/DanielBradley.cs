using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanielBradley : IAmAMicrosoftMVP
    {
        public string FirstName => "Daniel";
        public string LastName => "Bradley";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Microsoft Security MVP, author of ourcloudnetwork.com and lover of all things PowerShell, Intune and Entra ❤️";
        public string StateOrRegion => "Kent, UK";
        public string EmailAddress => "daniel@ourcloudnetwork.com";
        public string TwitterHandle => "DanielatOCN";
        public string MastodonHandle => "";
        public string GitHubHandle => "DanielBradley1";
        public string GravatarHash => "24eecd1d17ccfe3321b76fa29cbbe7de3e2c1d75d5a17ba13ec23149e7258c61";
        public GeoPosition Position => new GeoPosition(51.383833507924436, 1.4404015463492161);
        public Uri WebSite => new Uri("https://ourcloudnetwork.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ourcloudnetwork.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
