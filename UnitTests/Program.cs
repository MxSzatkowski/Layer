﻿using NUnit.Framework;
using FakeItEasy;
using Wrapper;
using NUnit.Framework.Internal.Execution;
using System.Runtime.InteropServices;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
 
        [Test]
        public void add_return30()
        {
            Ent wrap = new Ent();

            var c = 30;

            var result = wrap.Add(10, 20);

            Assert.That(result, Is.EqualTo(c));
        }
    }
}
