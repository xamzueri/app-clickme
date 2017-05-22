using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ClickMe.UiTests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Test_Click()
        {
            app.Tap(x => x.Marked("BtnClick"));
            app.Screenshot("Click #1");
            app.Tap(x => x.Marked("BtnClick"));
            app.Screenshot("Click #2");
            app.Tap(x => x.Marked("BtnClick"));
            app.Screenshot("Click #3");
        }
    }
}

