using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class EwertonJordao : IAmAMicrosoftMVP
    {
        public string FirstName => "Ewerton";
        public string LastName => "Jordão";
        public string ShortBioOrTagLine => "Automation lover, Speaker at .NetSP, DevOps Professionals , Azure Talks, SampaDevs. Technical Author, MVP Azure";
        public string StateOrRegion => "São Paulo, Brazil";
        public string EmailAddress => "";
        public string GravatarHash => "70ac0c6fd63afc54ddf5e3c927f51d02";
        public string TwitterHandle => "EwertonJordao";
        public string MastodonHandle => "";
        public string GitHubHandle => "EwertonJordao";
        public GeoPosition Position => new GeoPosition(-23.536729, -46.635690);
        public Uri WebSite => new Uri("https://medium.com/@ewertonjordao");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@ewertonjordao"); } }
        public string FeedLanguageCode => "en";
    }
}
