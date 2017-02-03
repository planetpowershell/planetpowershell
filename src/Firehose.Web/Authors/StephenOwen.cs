using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class StephenOwen : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Stephen";
        public string LastName => "Owen";
        public string ShortBioOrTagLine => "FoxDeploy.SubjectMatter = writes about PowerShell";
        public string StateOrRegion => "Atlanta";
        public string EmailAddress => "Stephen@foxdeploy.com";
        public string TwitterHandle => "FoxDeploy";
        public string GitHubHandle => "1RedOne";
        
        public Uri WebSite => new Uri("http://www.FoxDeploy.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://foxdeploy.com/tag/powershell/feed/"); } }

        public string GravatarHash => "3dd39b0d646f3b959b741eb0196c4c21";
    }
}
