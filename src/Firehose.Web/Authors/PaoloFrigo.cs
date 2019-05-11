using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PaoloFrigo : IAmACommunityMember
    {
        public string FirstName => "Paolo";
        public string LastName => "Frigo";
        public string ShortBioOrTagLine => "DevOps and System Engineer";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "paolo@scriptinglibrary.com";
        public string TwitterHandle => "paolofrigo_oz";
        public string GravatarHash => "444a848421a8068fc75d8cdd6cbd8eff";
        public string GitHubHandle => "paolofrigo";
        public GeoPosition Position => new GeoPosition(-37.816667, 144.966667);
        public Uri WebSite => new Uri("https://www.scriptinglibrary.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.scriptinglibrary.com/category/powershell/feed/"); }
        }
    }
}