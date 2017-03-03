using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class GrahamBeer : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Graham";
        public string LastName => "Beer";
        public string ShortBioOrTagLine => "System Engineer, PowerShell, WinOps and SCCM who is a huge automation fan!";
        public string StateOrRegion => "Southampton, UK";
        public string EmailAddress => "Graham.Beer@DTLK.co.uk";
        public string TwitterHandle => "GKBeer";
        public string GitHubHandle => "Graham-Beer";
        public string GravatarHash => "159bdc93f5c3783799b4d298d6d87dde";
        public GeoPosition Position => new GeoPosition(50.7167, -1.8833);

        public Uri WebSite => new Uri("https://graham-beer.github.io/#blog");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://graham-beer.github.io/feed.xml"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}