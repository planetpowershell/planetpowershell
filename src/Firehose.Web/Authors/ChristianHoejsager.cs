using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChristianHoejsager : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Christian";
        public string LastName => "Hoejsager";
        public string ShortBioOrTagLine => "Systems Administrator, author of scriptingchris.tech and automation enthusiast";
        public string StateOrRegion => "Denmark";
        public string EmailAddress => "christian@scriptingchris.tech";
        public string TwitterHandle => "_ScriptingChris";
        public string MastodonHandle => "";
        public string GitHubHandle => "ScriptingChris";
        public string GravatarHash => "d406f408c17d8a42f431cd6f90b007b1";
        public GeoPosition Position => new GeoPosition(55.709830, 9.536208);
        public Uri WebSite => new Uri("https://scriptingchris.tech/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://scriptingchris.tech/feed"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }

}
