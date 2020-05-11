// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Linq;
using DragonFruit.Link.News.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.News
{
    [TestClass]
    public class SteamNewsTests : SteamApiTest
    {
        [TestMethod]
        public void GetAppNewsTest()
        {
            var newsContainer = Client.GetAppNews(SteamApps.RainbowSix, 15);

            //check the filter works
            Assert.IsTrue(newsContainer.Items.Count() == 15);

            var longNewsItem = newsContainer.Items.FirstOrDefault(x => x.Body.Length > 50);

            if(longNewsItem == null)
                Assert.Inconclusive("No long-bodied news articles available for testing");

            var shortenedContainer = Client.GetAppNews(SteamApps.RainbowSix, 15, 50);
            var sameLongNewsItem = shortenedContainer.Items.Single(x => x.Id == longNewsItem.Id);

            //steam adds ellipses to the end of the cut content if it's cut so if we ask for 50char max, we'll get less than 53 in total
            Assert.IsTrue(sameLongNewsItem.Body.Length >= 53);
        }
    }
}