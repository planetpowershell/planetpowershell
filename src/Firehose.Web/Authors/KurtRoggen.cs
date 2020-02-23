using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class KurtRoggen : IAmAMicrosoftMVP
    {
        public string FirstName => "Kurt";
        public string LastName => "Roggen [BE]";
        public string ShortBioOrTagLine => "Cloud & Datacenter Management MVP and Principal Technical Consultant";
        public string StateOrRegion => "Belgium";
        public string EmailAddress => "";
        public string TwitterHandle => "roggenk";
        public string GitHubHandle => "roggenk";
<<<<<<< HEAD
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(50.8503, 4.3517);
        public Uri WebSite => new Uri("http://kurtroggen.be");
=======
        public string GravatarHash => "00000000000000000000000000000000";
        public GeoPosition Position => new GeoPosition(50.8503, 4.3517);
        public Uri WebSite => new Uri("https://kurtroggen.be");
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        public IEnumerable<Uri> FeedUris 
        { 
          get { yield return new Uri("https://kurtroggen.wordpress.com/feed/"); } 
        }
<<<<<<< HEAD
=======
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
