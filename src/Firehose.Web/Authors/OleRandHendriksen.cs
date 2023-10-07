using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class OleRandHendriksen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Ole";
        public string LastName => "Rand-Hendriksen";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "OS agnostic sysadmin that tends land in Microsoft territory. Father of 3. Reader of sci-fi and fantasy. Wearer of hoodies";
        public string StateOrRegion => "Norway";
        public string EmailAddress => "ole@randriksen.net";
        public string TwitterHandle => "randriksen";
        public string MastodonHandle => "@Randriksen@mastodon.social";
        public string GravatarHash => "112a3bb6a2f4af48ab67bd94b5feb1df335627417dd39e5f32202f0b62c3f0d8";
        public string GitHubHandle => "randriksen";
        public GeoPosition Position => new GeoPosition(59.9102752,11.0879039);

        public Uri WebSite => new Uri("https://www.randriksen.net");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.randriksen.net/feed.xml"); } }
        public bool Filter(SyndicationItem item)
        {
           // This filters out only the posts that have the "PowerShell" category
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
