using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BradleyWyatt : IAmAMicrosoftMVP
    {
        public string FirstName => "Bradley";
        public string LastName => "Wyatt";
        public string ShortBioOrTagLine => "Microsoft MVP, author of The Lazy Administrator, Co-Organizer of the Chicago PowerShell Conference, & Chicago PowerShell Users Group";
        public string StateOrRegion => "Geneva, IL, USA";
        public string EmailAddress => "brad@thelazyadministrator.com";
        public string TwitterHandle => "bwya77";
        public string MastodonHandle => "";
        public string GitHubHandle => "bwya77";
        public string GravatarHash => "c4eaa00e143c7abb1362dc9a8a48da09";
        public GeoPosition Position => new GeoPosition(41.887212,-88.302487);
        public Uri WebSite => new Uri("https://www.thelazyadministrator.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.thelazyadministrator.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
