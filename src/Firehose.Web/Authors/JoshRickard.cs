using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JoshRickard : IFilterMyBlogPosts
    {
        public string FirstName => "Josh";
        public string LastName => "Rickard";
        public string ShortBioOrTagLine => "IT & DFIR Professional, Windows Internals, Creator & Automator of things, Blogger, PowerShell expert, Python lover";
        public string StateOrRegion => "Missouri, USA";
        public string EmailAddress => "rickardja@live.com";
        public string TwitterHandle => "MS_dministrator";
        public string GitHubHandle => "MSAdministrator";
        public string GravatarHash => "a3cab24cca7ccf6c969a9161fa1405ef";
        public GeoPosition Position => new GeoPosition(38.9517, 92.3341);
        public Uri WebSite => new Uri("https://letsautomate.it");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://letsautomate.it/index.xml"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
        public string FeedLanguageCode => "en";
    }
}