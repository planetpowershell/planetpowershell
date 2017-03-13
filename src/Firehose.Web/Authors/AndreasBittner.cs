using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AndreasBittner : IAmACommunityMember
    {
        public string FirstName => "Andreas";
        public string LastName => "Bittner";
        public string ShortBioOrTagLine => "DevOp and MCSE Server 2012R2";
        public string StateOrRegion => "Saxony, Germany";
        public string EmailAddress => "";
        public string TwitterHandle => "Andreas_Bittner";
        public string GitHubHandle => "bobruhny";
        public string GravatarHash => "9e94e1e9014ad138df3f5281f814d755";
        public GeoPosition Position => new GeoPosition(49.4833, 10.7167);
        public Uri WebSite => new Uri("http://joinpowershell.de/de/new/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://joinpowershell.de/de/feed/"); } }
        
    }
}
