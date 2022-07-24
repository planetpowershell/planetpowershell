public class BruceWayne : IAmACommunityMember
    {
        public string FirstName => "Faris";
        public string LastName => "Malaeb";
        public string ShortBioOrTagLine => "System Automation and integration using PowerShell";
        public string StateOrRegion => "Abu Dhabi";
        public string EmailAddress => "farisnt@gmail.com";
        public string TwitterHandle => "FarisMalaeb";
        public string GravatarHash => "";
        public string GitHubHandle => "farismalaeb";
        public GeoPosition Position => new GeoPosition(24.471011,54.378537);

        public Uri WebSite => new Uri("https://powershellcenter.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.powershellcenter.com/feed"); } }
    }
