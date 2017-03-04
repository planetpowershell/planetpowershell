using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AdamBertram : IAmAMicrosoftMVP
    {
        public string FirstName => "Adam";
        public string LastName => "Bertram`";
        public string ShortBioOrTagLine => "Automation Engineer, writer, trainer, Microsoft MVP, fiercely independent, laid back guy that loves sharing.";
        public string StateOrRegion => "Evansville, IN";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "adbertram";
        public string GravatarHash => "f21b5adac336b3678098de870efcf994";
        public string GitHubHandle => "adbertram";
        public GeoPosition Position => new GeoPosition(37.996239,-87.54378);
        public Uri WebSite => new Uri("http://www.adamtheautomator.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.adamtheautomator.com/feed/"); }
        }
    }
}