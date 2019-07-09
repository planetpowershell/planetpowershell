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
        public string FirstName => "Gabriel";
        public string LastName => "Talavera";
        public string ShortBioOrTagLine => "Passionate about #PowerShell, Cloud & Automation, DevOps and CyberSecurity | Microsoft Certified Trainer & MCSE Core Infrastructure";
        public string StateOrRegion => "Asunción, Paraguay";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "gtalavera_ITPro";
        public string GravatarHash => "";
        public string GitHubHandle => "gabrieltalavera";
        public GeoPosition Position => new GeoPosition(-25.2981197,-57.5872534);
        public Uri WebSite => new Uri("https://blog.hybridcloud-ops.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.hybridcloud-ops.com/feeds/posts/default/-/powershell?alt=rss"); }
        }
    }
}
