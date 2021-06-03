using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JeffHill : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Jeff";
        public string LastName => "Hill";
        public string ShortBioOrTagLine => "SQL Server DBA with a love for PowerShell.";
        public string StateOrRegion => "Dallas, TX";
        public string EmailAddress => "Jeff.Hill@SQLAdm.in";
        public string TwitterHandle => "sql_jeff";
        public string GitHubHandle => "sqljeff";
        public string GravatarHash => "d83825f965c6ca452e31e9b328561f89";
        public GeoPosition Position => new GeoPosition(45.5131063, -122.670492);
        public Uri WebSite => new Uri("https://sqladm.in/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://sqladm.in/posts/index.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }
        public string FeedLanguageCode => "en";
    }

}
