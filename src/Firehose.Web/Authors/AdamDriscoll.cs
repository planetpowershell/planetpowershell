using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AdamDriscoll : IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Adam";
		public string LastName => "Driscoll";
		public string ShortBioOrTagLine => "Small business owner, software developer and PowerShell nerd.";
		public string StateOrRegion => "Hailey, ID";
		public string EmailAddress => string.Empty;
		public string TwitterHandle => "adamdriscoll";
		public string GravatarHash => "3394cd247460d377a3d59722dd3adbdb";
		public string GitHubHandle => "adamdriscoll";
		public GeoPosition Position => new GeoPosition(43.520942, -114.314395);
		public Uri WebSite => new Uri("https://ironmansoftware.com");
		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://blog.ironmansoftware.com/index.xml"); }
		}
		public bool Filter(SyndicationItem item)
		{
			return item.Title.Text.Contains("Daily PowerShell");
		}
		public string FeedLanguageCode => "en";
	}
}
