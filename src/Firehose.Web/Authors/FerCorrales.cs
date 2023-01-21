using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class FerCorrales : IAmACommunityMember
    {
        public string FirstName => "Fer";
        public string LastName => "Corrales";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Passionate about PowerShell and automation. Virtualization / Cloud Engineer";
        public string StateOrRegion => "Costa Rica";
        public string EmailAddress => "string.Empty";
        public string TwitterHandle => "FerCorrales_";
        public string MastodonHandle => "";
        public string GravatarHash => "f4b846ac7c5798b6700b2e9265a7acd0";
        public string GitHubHandle => "F3rC";
        public GeoPosition Position => new GeoPosition(9.864687, -83.920451);
        public Uri WebSite => new Uri("https://fercorrales.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://fercorrales.com/category/powershell/feed/"); } }
     	public string FeedLanguageCode => "en";
    }
	
}
