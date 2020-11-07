using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MichaelMilitoni : IAmACommunityMember
    {
        public string FirstName => "Michael"
        public string LastName => "Militoni";
        public string ShortBioOrTagLine => "An IT pro passionned and specialized in Virtualization";
        public string StateOrRegion => "Brussles, Belgium";
        public string EmailAddress => "mm@v-itpassion.be";
        public string TwitterHandle => "MichaelMilitoni";
        public string GitHubHandle => "itguru4u-be";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(41.887212,-88.302487);
        public Uri WebSite => new Uri("https://www.v-itpassion.be");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.v-itpassion.be/category/Powershell/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
