using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
public class LucFullenwarth : IAmACommunityMember, IFilterMyBlogPosts
{
    public string FirstName => "Luc";
    public string LastName => "Fullenwarth";
    public string ShortBioOrTagLine => "Luc is working as a Windows SysAdmin since 1999, and focuses mainly on Microsoft products (Windows, Azure, PowerShell, Active Directory, PKI, Security)";
    public string StateOrRegion => "Strasbourg, France";
    public string EmailAddress => "luke.blog@outlook.com";
    public string GravatarHash => "ec967d9f1a0a2070951f22d87309d2d3";
    public string GitHubHandle => "fullenw1";
    public string TwitterHandle => "";
    public GeoPosition Position => new GeoPosition(48.583636, 7.745839);
    public Uri WebSite => new Uri("https://itluke.online/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://itluke.online/feed/"); } }
    public bool Filter(SyndicationItem item)
    {
        // this filters out posts that do not have PowerShell in the title
        return item.Title.Text.ToLowerInvariant().Contains("powershell");
    }
    public string FeedLanguageCode => "en";
}
}