using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DarrenJRobinson : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Darren";
        public string LastName => "Robinson";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Bespoke Identity and Access Management Solutions";
        public string StateOrRegion => "Sydney, NSW, Australia";
        public string EmailAddress => "darren@darrenjrobinson.com";
        public string TwitterHandle => "darrenjrobinson";
        public string MastodonHandle => "";
        public string GravatarHash => "e56b6d66daa1d249647109a520ce8759";
        public string GitHubHandle => "darrenjrobinson";
        public GeoPosition Position => new GeoPosition(-33.865143, 151.209900);
        public string FeedLanguageCode => "en";

        public Uri WebSite => new Uri("https://blog.darrenjrobinson.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.darrenjrobinson.com/feed/"); } }
		
		public bool Filter(SyndicationItem item)
        {            
            // This filters out only the posts that have the "PowerShell" category
            return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
    }
}