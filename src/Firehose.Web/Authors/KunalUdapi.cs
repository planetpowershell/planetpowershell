using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KunalUdapi : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Kunal";
        public string LastName => "Udapi";
        public string ShortBioOrTagLine => "vGeek - Eating Powershell, Breathing cmdlet, Dreaming automation, Building crazy scripts";
        public string StateOrRegion => "Maharashtra, India";
        public string EmailAddress => "kunaludapi@gmail.com";
        public string TwitterHandle => "kunaludapi";
        public string GravatarHash => "341dff90fe3ea6e6e7d771a0c04a3887";
        public string GitHubHandle => "kunaludapi";
        public GeoPosition Position => new GeoPosition(18.5714625,73.8274168);

        public Uri WebSite => new Uri("http://vcloud-lab.com");

        public IEnumerable<Uri> FeedUris { 
		get { yield return new Uri("https://vcloud-lab.com/entries.atom"); } 
	}

	    public bool Filter(SyndicationItem item) {
		    return item.Title.Text.ToLowerInvariant().Contains("powershell");
        }
    }
}
