using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class MattBobke : IAmACommunityMember, IFilterMyBlogPosts
{
    public string FirstName => "Matt";
    public string LastName => "Bobke";
    public string ShortBioOrTagLine => "Desktop Support Specialist with admninistrative tendencies excited about PowerShell and automation.";
    public string StateOrRegion => "California, United States";
    public string GravatarHash => "6f38a96cd055f95eacd1d3d102e309fa";
    public string EmailAddress => "matt@mattbobke.com";
    public string TwitterHandle => "MattBobke";
    public string GitHubHandle => "mcbobke";
    public GeoPosition Position => new GeoPosition(33.5676842, -117.7256083);
    public Uri WebSite => new Uri("https://mattbobke.com");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mattbobke.com/feed"); } }
    public bool Filter(SyndicationItem item)
    {
        // This filters out only the posts that have the "PowerShell" category
        return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
    }
    public string FeedLanguageCode => "en";
}

}