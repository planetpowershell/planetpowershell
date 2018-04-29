using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class StephanosConstantinou : IAmACommunityMember
    {
        public string FirstName => "Stephanos";
        public string LastName => "Constantinou";
        public string ShortBioOrTagLine => "Senior System Administrator. I am using PowerShell a lot to perform day to day tasks and automate procedures.";
        public string StateOrRegion => "Limassol,Cyprus";
        public string TwitterHandle => "SCPowerShell";
        public string GravatarHash => "04de5e0523cf48e9493c11905fd5999f";
        public string GitHubHandle => "SConstantinou";
        public GeoPosition Position => new GeoPosition(34.706249, 33.022578);

        public Uri WebSite => new Uri("https://www.sconstantinou.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.sconstantinou.com/feed/"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}
