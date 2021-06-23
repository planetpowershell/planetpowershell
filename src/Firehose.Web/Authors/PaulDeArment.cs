using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PaulDeArment : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Paul";
        public string LastName => "DeArment";
        public string ShortBioOrTagLine => "Systems Engineer, PowerShell enthusiast, dog owner, lover of all thing tech, founder of Milwaukee PowerShell user group, and someone trying to find their way in things.";
        public string StateOrRegion => "Franklin, USA";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "pdearmen";
        public string GitHubHandle => "armentpau";
        public string GravatarHash => "7baa3ddee66f5b5e251d82079a5f6720";
        public GeoPosition Position => new GeoPosition(42.9011938,-88.0391506);

        public Uri WebSite => new Uri("https://randomizedharmony.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://randomizedharmony.com/blog/?category=PowerShell&format=rss"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
