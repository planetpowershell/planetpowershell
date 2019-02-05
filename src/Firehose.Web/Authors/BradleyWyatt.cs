using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BradleyWyatt : IAmACommunityMember
    {
        public string FirstName => "Bradley";
        public string LastName => "Wyatt";
        public string ShortBioOrTagLine => "Finding wayt to do the most work with the least effort possible";
        public string StateOrRegion => "Chicago";
        public string EmailAddress => "brad@thelazyadministrator.com";
        public string GravatarHash => "c4eaa00e143c7abb1362dc9a8a48da09";
        public string TwitterHandle => "bwya77";
        public string GitHubHandle => "bwya77";

        public Uri WebSite => new Uri("https://www.thelazyadministrator.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.thelazyadministrator.com/feed/"); } }
    }
} 
