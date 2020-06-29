using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KevinCallanan : IAmACommunityMember
    {
        public string FirstName => "Kevin";
        public string LastName => "Callanan";
        public string ShortBioOrTagLine => "Hi, I’m Kevin. I’m an Advisory Consultant living in Chicago, IL specializing in infrastructure technology such as Exchange, Skype, AD, O365, Windows, VMware.";
        public string StateOrRegion => "Chicago";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "kevincallanan";
        public string GravatarHash => "efb7bbc92a66d185905c300ad5eafadb";
        public string GitHubHandle => "kevincallanan";
        public GeoPosition Position => new GeoPosition(41.882457, -87.644678);
        public Uri WebSite => new Uri("https://itsoundbytes.com/tag/powershell/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://itsoundbytes.com/tag/powershell/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
