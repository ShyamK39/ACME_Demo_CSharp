﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.Tests
{
    [TestClass()]
    public class LoggingServiceTests
    {
        [TestMethod()]
        public void SayHello_Success()
        {
            // Arrange
            var logger = new LoggingService();
            var expected = "Hello from the logging service";

            // Act
            var actual = logger.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}