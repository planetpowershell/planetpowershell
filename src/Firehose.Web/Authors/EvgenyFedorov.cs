using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class EvgenyFedorov : IAmACommunityMember
    {
        public string FirstName => "Evgeny";
        public string LastName => "Fedorov";
        public string ShortBioOrTagLine => "Software Developer, DevOps Engineer, Chess Player";
        public string StateOrRegion => "Prague, Czech Republic";
        public string GravatarHash => "904c3bb52fa45d319357aa06e7e15f56";
        public string TwitterHandle => "yudinetz";
        public string GitHubHandle => "evgenyfedorov2";
        public GeoPosition Position => new GeoPosition(50.032283, 14.529762);

        public Uri WebSite => new Uri("https://evgenyfedorov.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://evgenyfedorov.com/rss"); } }
        public string FeedLanguageCode => "en";
    }
}
