# C:\> Get-Greeting 'Welcome to PlanetPowerShell.com' [![Build status](https://ci.appveyor.com/api/projects/status/u2rw5yhq0638shf1?svg=true)](https://ci.appveyor.com/project/PlanetPowershell/planetpowershell)

Welcome!

The goal of PlanetPowerShell is to provide an aggregated feed of PowerShell community content. If you write about PowerShell, then jump in and add your blog to the feed. The only thing we wask is that you do not violate the community [code of conduct] ()

This site couldn't have been made without the help of Readify and the Planet Xamarin team (who I have blatantly stolen the content from, yay Open Source!). For more information see the Acknowledgements.

# C:\> Get-Help 'Adding yourself as an author'

## Guidlines for submission
- I have a valid blog & RSS URL
- Host NO malicious or offensive content on the blog (including photos, swearing, etc.)
- Blog is active with atleast 3 PowerShell related blog posts in the last 6 months
- Blog content is my own, and is not someone elses work
- The content is not sales focused
- If the blog has mixed content (PowerShell and Personal/Non-PowerShell blogs) a filter has been applied
- If you delete your blog you will come delete your blog from Planet PowerShell
- Your blog may be removed at any time if any of these are broken.

## How to add yourself
Addin yourself as an author is easy! All you need to do is fork this project, add yourself to the [author folder] as your very own class. You need to ensure that you implement the `IAmACommunityMember` interface.

You can even do this via the GitHub editor, just don't forget to _add the class to the .csproj_ file. If you have never done anything like this, there are plenty of people that can help!

The result should look something like this:

``` csharp
public class BruceWayne : IAmACommunityMember
{
    public string FirstName => "Bruce";
    public string LastName => "Wayne";
    public string ShortBioOrTagLine => "potentially batman";
    public string StateOrRegion => "Gotham";
    public string EmailAddress => "rescueme@planetpowershell.com";
    public string TwitterHandle => "batman";
    public string GravatarHash => "42abc1337def";

    public Uri WebSite => new Uri("https://planetpowershell.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://planetpowershell.com/rss"); } }
}
```

A few things: 
- Name the class after your first and lastname with CamelCase
- The `FirstName` and `LastName` property should resemble that same name
- `ShortBioOrTagLine` property can be whatever you like. If you can't think of anything choose: 'software engineer' or 'software engineer at Microsoft'
- `StateOrRegion` will be your geographical location, i.e.: Holland, New York, etc.
- `EmailAddress` and `TwitterHandle` should be pretty clear, `TwitterHandle` without the leading @
- The `Website` property can be your global website or whatever you want people to look at
- And finally with `FeedUris` you can supply one or more URIs which resemble your blogs. Your blogs should be provided in RSS (Atom) format and of course be about PowerShell. 
- If you do not want your e-mailaddress publicly available but you _do_ want to show your Gravatar go to https://en.gravatar.com/site/check/ and get your hash! If you don't fill the hash, you will be viewed as a silhouette.

If you also do some blogging about other stuff, no worries! You're fine! Just have a look at the next section on how to filter out your PowerShell specific posts.

###Special note for Microsoft MVPs
Let us know that you are a Microsoft MVP using the `IAmAMicrosoftMVP` interface.
``` csharp
public class MVPGuy : IAmAMicrosoftMVP
    {
        public string FirstName => "Awesome";
        public string LastName => "Sauce";
        public string ShortBioOrTagLine => "unicorn tamer";
        public string StateOrRegion => "127.0.0.1";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "theboss";

        public Uri WebSite => new Uri("http://www.awesomesite.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.awesomesite.com/feed/"); } }

        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2016, 4, 1);
        public string GravatarHash => "";
    }
```

## Filtering to just PowerShell

Planet PowerShell is all about PowerShell content. To ensure that the feed only contains relevant content you can implement the `IFilterMyBlogPosts` interface on your author class.

``` csharp
public class BruceWayne : IAmACommunityMember, IFilterMyBlogPosts
{
    // ... Author properties from the above class, removed for brevity

    public bool Filter(SyndicationItem item)
    {
        // Here you filter out the given item by the criteria you want, i.e.
        // this filters out posts that do not have PowerShell in the title
        return item.Title.Text.ToLowerInvariant().Contains("powershell");
        
        // This filters out only the posts that have the "PowerShell" category
        return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        
        // Of course you can make the checks as complicated as you want and combine some stuff
        return item.Title.Text.ToLowerInvariant().Contains("powershell") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
    }
}
```

# A small step for an author...

A big step for mankind! Last thing that remains is submit a Pull Request to us and whenever it gets merged: hooray! You're an author now!

Enjoy all of our great content! 

Of course you are more than welcome to submit other features and bugfixes as well.

# Acknowledgements
* Thanks to Readify for open sourcing their employee blog aggregation platform, which Planet Xamarin forked. Looking for your next challenge? [Readify is hiring](https://join.readify.net/?source=StaffReferral&campaign=kieran.jacobsen) and offers relocation services for developers from abroad.
* Big thanks to [Planet Xamarin](https://planetxamarin.com), they really did a lot of the hard work in getting this setup.
* Thanks to [our awesome contributors](https://github.com/planetpowershell/planetpowershell/graphs/contributors) and our [community of authors](https://github.com/planetpowershell/planetpowershell/tree/master/src/Firehose.Web/Authors) who make this all possible.
