using Firehose.Web.Extensions;
using System;
using System.ServiceModel.Syndication;
using Xunit;

namespace UnitTest
{
    public class SyndicationItemExtensionsTest
    {
        [Fact]
        public void FilterPowerShellTitleTest()
        {
            var item = new SyndicationItem("some blog post about PowerShell android stuff", "whatever", new Uri("http://derp.org"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about native android stuff", "whatever", new Uri("http://derp.org"));

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);
        }

        [Fact]
        public void FilterPowerShellCategoryTest()
        {
            var item = new SyndicationItem();
            item.Categories.Add(new SyndicationCategory("android"));
            item.Categories.Add(new SyndicationCategory("ios"));
            item.Categories.Add(new SyndicationCategory("PowerShell"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item.Categories.RemoveAt(2);

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);
        }

        [Fact]
        public void FitlerPowerShellTitleAndCategoryTest()
        {
            var item = new SyndicationItem("some blog post about PowerShell android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("PowerShell"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about java android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("java"));

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);

            item = new SyndicationItem("some blog post about java android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("PowerShell"));

            ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about PowerShell android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("java"));

            ok = item.ApplyDefaultFilter();
            Assert.True(ok);
        }
    }
}
