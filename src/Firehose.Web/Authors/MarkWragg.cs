using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
namespace Firehose.Web.Authors
{
	public class MarkWragg : IAmACommunityMember
	{
		public string FirstName => "Mark";
		public string LastName => "Wragg";
		public string ShortBioOrTagLine => "Operations Manager interested in all things Windows, Powershell, AWS, Azure, Chef etc.";
		public string StateOrRegion => "Hook, England";
		public string GitHubHandle => "markwragg";
        public string TwitterHandle => "markwragg";
		public string GravatarHash => "e8e1b8d0e98f84b10a03f9430334b02f";
		public GeoPosition Position => new GeoPosition(51.2809060,-0.9630430);

		public Uri WebSite => new Uri("https://wragg.io/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://wragg.io/tag/powershell/rss"); } }
		public string FeedLanguageCode => "en";
	}
}
