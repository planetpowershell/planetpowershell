using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MateuszCzerniawski : IAmACommunityMember
    {
        public string FirstName => "Tomasz";
        public string LastName => "Dabrowski";
        public string ShortBioOrTagLine => "IT Pro for 12 year. PowerShell and WinOps enthusiast.";
        public string StateOrRegion => "Wroclaw, Poland";
        public string EmailAddress => "dombros@gmail.com";
        public string TwitterHandle => "Dom_Bros";
        public string GitHubHandle => "dombros";
        public string GravatarHash => "aab345407bf784ea4e40334d3ab51eab";
        public GeoPosition Position => new GeoPosition(51.1078850,17.0385380);

        public Uri WebSite => new Uri("https://dombrosblog.wordpress.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://dombrosblog.wordpress.com/feed/"); } }
    }
}
