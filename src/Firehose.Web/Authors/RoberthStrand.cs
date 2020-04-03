using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RoberthStrand : IAmACommunityMember
    {
        public string FirstName => "Roberth";
        public string LastName => "Strand";
        public string ShortBioOrTagLine => "PowerShell, Azure, Security and other fun stuff!";
        public string StateOrRegion => "Tromsø, Norway";
        public string EmailAddress => "me@robstr.dev";
        public string TwitterHandle => "RoberthTweets";
        public string GravatarHash => "0f8d0c1b68924de4beed584aefd30e20";
        public string GitHubHandle => "roberthstrand";
        public GeoPosition Position => new GeoPosition(69.648491, 18.983705);
        public Uri WebSite => new Uri("https://robstr.dev");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://robstr.dev/powershell"); }
        }
        public string FeedLanguageCode => "en";
    }
}
