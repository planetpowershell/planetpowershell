using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

public class MattBobke : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Matt";
        public string LastName => "Bobke";
        public string ShortBioOrTagLine => "Desktop Support Specialist with sysadmin/sysengineer/devops tendencies excited about PowerShell and automation.";
        public string StateOrRegion => "California, United States";
        public string GravatarHash => "";
        public string EmailAddress => "matt@mattbobke.com";
        public string TwitterHandle => "MattBobke";
        public string GitHubHandle => "mcbobke";
        public GeoPosition Position => new GeoPosition(33.6469, -117.6861);

        public Uri WebSite => new Uri("https://blog.mattbobke.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.mattbobke.com/feed/atom/"); } }

        public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }