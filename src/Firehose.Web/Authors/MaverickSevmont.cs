using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors {
 
 public class MaverickSevmont : IAmACommunityMember
    {
        public string FirstName => "Maverick";
        public string LastName => "Sevmont";
        public string ShortBioOrTagLine => "Yet another PowerShell nerd";
        public string StateOrRegion => "Mexico City, Mexico";
        public string EmailAddress => "sevmont@gmail.com";
        public string TwitterHandle => "";
        public string GravatarHash => "d121a69f0572374af7efcc407160efc9";
        public string GitHubHandle => "mavericksevmont";
        public GeoPosition Position => new GeoPosition(19.432608, -99.133209);

        public Uri WebSite => new Uri("https://tech.mavericksevmont.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://tech.mavericksevmont.com/blog/feed/"); } }
    }

    }
