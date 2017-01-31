using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MathieuBuisson : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Mathieu";
        public string LastName => "Buisson";
        public string ShortBioOrTagLine => "Senior DevOps Engineer. Works on deployment automation, mostly with PowerShell and DSC.";
        public string StateOrRegion => "Dublin, Ireland";
        public string EmailAddress => "";
        public string TwitterHandle => "TheShellNut";
        public string GravatarHash => "25061653796d5c748192c68e2eb6bde8";

        public Uri WebSite => new Uri("http://theshellnut.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://theshellnut.com/feed/"); }
        }

        public string GitHubHandle => "MathieuBuisson";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }

        public GeoPosition Position => new GeoPosition(53.294469, -6.141136);
    }
}