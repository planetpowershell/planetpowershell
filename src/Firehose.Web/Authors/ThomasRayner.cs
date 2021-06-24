using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThomasRayner : IWorkAtMicrosoft
    {
        public string FirstName => "Thomas";
        public string LastName => "Rayner";
        public string ShortBioOrTagLine => "Senior Security Systems Engineer @ Microsoft";
        public string StateOrRegion => "Redmond";
        public string EmailAddress => "thmsrynr@outlook.com";
        public string TwitterHandle => "MrThomasRayner";
        public string GitHubHandle => "thomasrayner";
        public string GravatarHash => "28dbce395fcef492a3874f84afea8144";
        public GeoPosition Position => new GeoPosition(47.642384, -122.126984);

        public Uri WebSite => new Uri("https://thomasrayner.ca");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://thomasrayner.ca/feed"); } }
        public string FeedLanguageCode => "en";
    }

}
