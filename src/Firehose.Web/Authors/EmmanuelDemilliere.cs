using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
    public class EmmanuelDemilliere : IAmAMicrosoftMVP
    {
        public string FirstName => "Emmanuel";
        public string LastName => "Demilliere";
        public string ShortBioOrTagLine => "PowerShell MVP focused on AD & Office 365";
        public string StateOrRegion => "France";
        public string TwitterHandle => "edemilliere";
        public string GitHubHandle => "edemilliere";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(45.750000, 4.850000);
 
        public Uri WebSite => new Uri("https://itfordummies.net");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://itfordummies.net/feed/"); } }
 
        public bool Filter(SyndicationItem item)
        {

            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));

        }
        public string FeedLanguageCode => "en";
    }
}