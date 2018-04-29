using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class TomaszDabrowski : IAmACommunityMember
    {
        public string FirstName => "Tomasz";
        public string LastName => "Dabrowski";
        public string ShortBioOrTagLine => "IT pro with 12 years of experience. PowerShell and WinOps enthusiast. Polish PowerShell User Group co-founder. Search.Learn.Automate.Share";
        public string StateOrRegion => "Wroclaw, Poland";
        public string TwitterHandle => "Dom_Bros";
        public string GitHubHandle => "dombros";
        public string GravatarHash => "aab345407bf784ea4e40334d3ab51eab";
        public GeoPosition Position => new GeoPosition(51.1078850,17.0385380);

        public Uri WebSite => new Uri("https://dombrosblog.wordpress.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://dombrosblog.wordpress.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
