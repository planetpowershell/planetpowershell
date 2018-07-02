public class MaximilianLærum : IAmACommunityMember
    {
        public string FirstName => "Maximilian";
        public string LastName => "Lærum";
        public string ShortBioOrTagLine => "PowerShell enthusiast";
        public string StateOrRegion => "Norway";
        public string TwitterHandle => "tr4psec";
        public string GravatarHash => "0e45a9759e36d29ac45cf020882cdf5c";
        public string GitHubHandle => "Tr4pSec";

        public Uri WebSite => new Uri("https://get-help.guru/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://get-help.guru/rss"); } }
    }
