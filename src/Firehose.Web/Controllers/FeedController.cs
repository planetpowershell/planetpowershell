using System;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
using System.Linq;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using BlogMonster.Web;
using Firehose.Web.Extensions;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class FeedController : BaseController
    {
        private readonly CombinedFeedSource _combinedFeedSource;

        public FeedController(CombinedFeedSource combinedFeedSource)
        {
            _combinedFeedSource = combinedFeedSource;
        }

        [Route("feed")]
        public RssFeedResult Index(int? numPosts = 50, string lang = "")
        {
            var feed = GetFeed(numPosts, lang);
            return new RssFeedResult(feed);
        }

        private SyndicationFeed GetFeed(int? numPosts, string lang = "")
        {
            SyndicationFeed originalFeed = null;
<<<<<<< HEAD
            try
            {
                originalFeed = _combinedFeedSource.Feed;
                if (numPosts == null) return originalFeed;

                var items = _combinedFeedSource.Feed.Items
=======

            try
            {
                string language = null;
                if (!string.IsNullOrEmpty(lang))
                    language = CultureInfo.CreateSpecificCulture(lang).Name;

                originalFeed = _combinedFeedSource.GetFeed(language);
                if (numPosts == null) return originalFeed;

                var items = _combinedFeedSource.GetFeed(language).Items
                    .DistinctBy(i => i.Id)
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
                    .OrderByDescending(item => item.PublishDate)
                    .Take((int)numPosts)
                    .ToArray();

                var shorterFeed = originalFeed.Clone(false);
                var itemsField = shorterFeed.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
                itemsField.SetValue(shorterFeed, items);

                return shorterFeed;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

                return originalFeed;
            }
        }
    }
}