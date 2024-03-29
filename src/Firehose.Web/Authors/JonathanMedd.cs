﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JonathanMedd : IAmAMicrosoftMVP
    {
        public string FirstName => "Jonathan";
        public string LastName => "Medd";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Microsoft MVP - Cloud & Datacenter Management";
        public string StateOrRegion => "United Kingdom";
        public string EmailAddress => "jon_medd@hotmail.com";
        public string TwitterHandle => "jonathanmedd";
        public string MastodonHandle => "";
        public string GitHubHandle => "jonathanmedd";
        public string GravatarHash => "1b01887ac956ccd429a4209ade5cdb68";
        public GeoPosition Position => new GeoPosition(50.8245565, -1.2148624);
        public Uri WebSite => new Uri("https://www.jonathanmedd.net");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds.feedburner.com/JonathanMeddsBlogPowerShell"); } }
        public string FeedLanguageCode => "en";
    }
}
