using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MatthewDowst : IAmACommunityMember
    {
        public string FirstName => "Matthew";
        public string LastName => "Dowst";
        public string ShortBioOrTagLine => "I am passionate about all things DevOps and automation, utilizing multiple different technologies, but PowerShell is my passion. I have over 15 years of experience in IT management and consulting, working with System Center, Azure, VMware, Hyper-V, Exchange, and Office 365.";
        public string StateOrRegion => "Denton, TX";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "mdowst";
        public string GravatarHash => "8d4382ff796ead8712ffdc349a055ba6";
        public string GitHubHandle => "mdowst";
        public GeoPosition Position => new GeoPosition(33.214966,-97.133034);
        public Uri WebSite => new Uri("https://www.dowst.dev");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.dowst.dev/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
