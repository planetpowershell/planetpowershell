using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class CraigGumbley : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Craig";
        public string LastName => "Gumbley";
        public string ShortBioOrTagLine => "Automation and Orchestration enthusiast";
        public string StateOrRegion => "Warwickshire, United Kingdom";
        public string EmailAddress => "";
        public string TwitterHandle => "_chelnak";
        public string GitHubHandle => "chelnak";
        public string GravatarHash => "ad535ae27561b4df47261f2cebeed368";
        public GeoPosition Position => new GeoPosition(52.2823160, -1.5849270);

        public Uri WebSite => new Uri("https://www.helloitscraig.co.uk/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.helloitscraig.co.uk/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}