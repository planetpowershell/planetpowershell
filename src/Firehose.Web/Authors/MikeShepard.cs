using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class MikeShepard : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Mike";
        public string LastName => "Shepard";
        public string ShortBioOrTagLine => "Solutions architect for a software company, using PowerShell since 2007.";
        public string StateOrRegion => "Missouri,USA";
        public string TwitterHandle => "MikeShepard70";
        public string GitHubHandle => "MikeShepard";
        public string GravatarHash => "45bc55fe65c938b0c65c20101dd73b6c";
        public GeoPosition Position => new GeoPosition(37.1291,-93.5151 );
        public Uri WebSite => new Uri("https://powershellstation.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://powershellstation.com/feed"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}