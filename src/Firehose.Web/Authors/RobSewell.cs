using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RobSewell : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Rob";
        public string LastName => "Sewell";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "is a PowerShell Bearded Fella and SQL Server DBA ";
        public string StateOrRegion => "Somerset, UK";
        public string EmailAddress => "";
        public string TwitterHandle => "sqldbawithbeard";
        public string MastodonHandle => "@robsewell@tech.lgbt";
        public string GravatarHash => "bdbac4b4103fc16a37e87bd02945219f";

        public Uri WebSite => new Uri("https://sqldbawithabeard.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://sqldbawithabeard.com/feed/"); }
        }

        public string GitHubHandle => "sqldbawithabeard";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }

        public GeoPosition Position => new GeoPosition(50.952495, -3.267374);
        public string FeedLanguageCode => "en";
    }
}
