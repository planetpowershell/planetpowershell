using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AlexNeihaus : IAmACommunityMember
    {
        public string FirstName => "Alex";
        public string LastName => "Neihaus";
        public string ShortBioOrTagLine => "AWS Cloud Architect";
        public string StateOrRegion => "Boston, MA, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "yobyot";
        public string GitHubHandle => "yobyot";
        public string GravatarHash => "84df1a56afda0ae7b7b10e7b8cf5972e";
        public GeoPosition Position => new GeoPosition(42.355291, -71.066245);
        public Uri WebSite => new Uri("https://www.yobyot.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.yobyot.com/category/powershell/feed/"); } }
        
    }
}
