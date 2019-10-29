using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class FrancoisxavierCat : IAmAMicrosoftMVP
    {
        public string FirstName => "Francois-Xavier";
        public string LastName => "Cat";
        public string ShortBioOrTagLine => "Systems Engineer, Microsoft MVP, French PowerShell UserGroup Organizer";
        public string StateOrRegion => "San Francisco Bay, CA, USA";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "lazywinadmin";
        public string GitHubHandle => "lazywinadmin";
        public string GravatarHash => "d0f72a655be62f8c34d4d1e3c5ba278a";
        public GeoPosition Position => new GeoPosition(37.5545405,-122.2699152);
        public Uri WebSite => new Uri("https://lazywinadmin.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://lazywinadmin.com/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
