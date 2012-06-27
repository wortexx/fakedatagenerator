using System;
using Fake.Data.Misc.NAICS;
using NUnit.Framework;
using Should.Fluent;

namespace Fake.Data.Tests.Misc.NAICS
{
    [TestFixture]
    public class WhenIGetNextNaics
    {
        private NaicsProvider _naics;
        private Naics _result;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _naics = new NaicsProvider(new Random());
            _result = _naics.GetRandom();
        }

        [Test]
        public void ShouldReturnNaics()
        {
            _result.Should().Be.OfType<Naics>();
        }

        [Test]
        public void ShouldBeOneOfCorrectValues()
        {
            _naics.Should().Contain.Item(_result);
        }
    }
}