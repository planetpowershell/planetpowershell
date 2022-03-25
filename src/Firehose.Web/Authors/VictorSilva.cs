using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class VictorSilva : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Victor";
        public string LastName => "Silva";
        public string ShortBioOrTagLine => "";
        public string StateOrRegion => "Montevideo, Uruguay";
        public string EmailAddress => "vmsilvamolina@hotmail.com";
        public string TwitterHandle => "vmsilvamolina";
        public string GitHubHandle => "vmsilvamolina";
        public string GravatarHash => "f641e3c18a5af7afb0e78527f2ceaa99";
        public GeoPosition Position => new GeoPosition(-34.908, -56.176);
 
        public Uri WebSite => new Uri("https://blog.victorsilva.com.uy");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds.feedburner.com/vmsilvamolina"); } }
 
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
