using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class QuintenSteenhuis : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Quinten";
        public string LastName => "Steenhuis";
        public string ShortBioOrTagLine => "I am a lawyer and technologist in Boston. I write about systems administration and access to justice with a focus on Powershell and legal technology.";
        public string StateOrRegion => "Boston, USA";
        public string TwitterHandle => "qsteenhuis";
        public string GitHubHandle => "nonprofittechy";
        public string GravatarHash => "df83ceb7d3b3b924f131abc408c3bfa";
        public GeoPosition Position => new GeoPosition(42.364086, -71.060546);

        public Uri WebSite => new Uri("https://nonprofittechy.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://nonprofittechy.com/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";

    }
}
