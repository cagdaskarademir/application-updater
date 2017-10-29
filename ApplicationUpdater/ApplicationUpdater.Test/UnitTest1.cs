using System;
using ApplicationUpdater.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationUpdater.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var settings = new ApplicationGenericSettings()
                .SetUrl("");

        }
    }
}
