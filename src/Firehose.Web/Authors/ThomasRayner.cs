using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
<<<<<<< HEAD
    public class ThomasRayner : IAmAMicrosoftMVP
    {
        public string FirstName => "Thomas";
        public string LastName => "Rayner";
        public string ShortBioOrTagLine => "Microsoft MVP - Cloud & Datacenter Management";
        public string StateOrRegion => "Canada";
        public string EmailAddress => "thmsrynr@outlook.com";
        public string TwitterHandle => "MrThomasRayner";
        public string GitHubHandle => "ThmsRynr";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(53.5443890, -113.4909270);

        public Uri WebSite => new Uri("http://workingsysadmin.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://workingsysadmin.com/feed/"); } }
=======
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
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }

}
