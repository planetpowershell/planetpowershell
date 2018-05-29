using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class ThomasRayner : IAmAMicrosoftMVP
    {
        public string FirstName => "Thomas";
        public string LastName => "Rayner";
        public string ShortBioOrTagLine => "Microsoft MVP - Cloud & Datacenter Management";
        public string StateOrRegion => "Canada";
        public string TwitterHandle => "MrThomasRayner";
        public string GitHubHandle => "ThmsRynr";
        public string GravatarHash => "28dbce395fcef492a3874f84afea8144";
        public GeoPosition Position => new GeoPosition(53.5443890, -113.4909270);

        public Uri WebSite => new Uri("https://workingsysadmin.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://workingsysadmin.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }

}
