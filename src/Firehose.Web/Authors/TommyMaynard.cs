using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class TommyMaynard : IAmACommunityMember
    {
        public string FirstName => "Tommy";
        public string LastName => "Maynard";
        public string ShortBioOrTagLine => "Information Technology Professional (PowerShell Enthusiast)";
        public string StateOrRegion => "Arizona, USA";
        public string EmailAddress => "tommy@tommymaynard.com";
        public string TwitterHandle => "thetommymaynard";
        public string GitHubHandle => "tommymaynard";
        public string GravatarHash => "dea0a101353757985987705b513cc540";
        public GeoPosition Position => new GeoPosition(32.2217, -110.9265);

<<<<<<< HEAD
        public Uri WebSite => new Uri("http://tommymaynard.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://tommymaynard.com/feed/"); } }
=======
        public Uri WebSite => new Uri("https://tommymaynard.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://tommymaynard.com/feed/"); } }
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
<<<<<<< HEAD
=======
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}