using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class ClaudioSilva : IAmAMicrosoftMVP
    {
        public string FirstName => "Cláudio";
        public string LastName => "Silva";
        public string ShortBioOrTagLine => "SQL Server DBA and PowerShell MVP who loves to automate any process that needs to be done more than a couple of times.";
        public string StateOrRegion => "Sintra, Portugal";
        public string TwitterHandle => "claudioessilva";
        public string GravatarHash => "c01100dc9b797cc424e48ca9c5ecb76f";
        public string GitHubHandle => "claudioessilva";
        public GeoPosition Position => new GeoPosition(38.754074938, -9.2808723);
        public Uri WebSite => new Uri("https://claudioessilva.eu");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://claudioessilva.eu/category/powershell/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
