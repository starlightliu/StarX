using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;
using NUnit.Framework;

namespace StarX.Common.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void LogTest()
        {
            var log = LogManager.GetCurrentClassLogger();
            log.Error("test");
        }
    }
}
