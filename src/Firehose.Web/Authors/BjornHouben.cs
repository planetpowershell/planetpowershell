using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BjornHouben : IAmACommunityMember
    {
        public string FirstName => "Bjorn";
        public string LastName => "Houben";
        public string ShortBioOrTagLine => "Blogging about practical PowerShell uses and other things I find interesting";
        public string StateOrRegion => "Heerlen, Netherlands";
        public string TwitterHandle => "bjornhouben";
        public string GravatarHash => "7d072aaf4d60ec2a94367e744a626ea0";
        public string GitHubHandle => "bjornhouben";
        public GeoPosition Position => new GeoPosition(50.8881740, 5.9794990);
        public Uri WebSite => new Uri("https://blog.bjornhouben.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.bjornhouben.com/category/powershell/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
