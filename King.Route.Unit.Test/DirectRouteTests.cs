namespace King.Route.Unit.Test
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DirectRouteTests
    {
        [SetUp]
        public void Setup()
        {
            var config = new RoutingConfiguration();
            config.MapAttributeRoutes();
        }

        [Test]
        public void Constructor()
        {
            new DirectRoute();
        }

        [Test]
        public void IsIQueue()
        {
            Assert.IsNotNull(new DirectRoute() as IRouteTo);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvokeRouteNull()
        {
            var queue = new DirectRoute();
            queue.Invoke(null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvokeRouteUnknown()
        {
            var queue = new DirectRoute();
            queue.Invoke(Guid.NewGuid().ToString());
        }

        [Test]
        public void TestRoundTrip()
        {
            var random = new Random();
            var expected = random.Next();

            var route = new DirectRoute();
            route.Send("Test/Set", expected);

            var value = route.Get<int>("Test/Get");

            Assert.AreEqual(expected, value);
        }

        [Test]
        public void TestNonRoundTrip()
        {
            var random = new Random();
            var expected = random.Next();

            var route = new DirectRoute();
            route.Send("TestNon/Set", expected);

            var value = route.Get<int>("TestNon/Red");

            Assert.AreEqual(expected, value);
        }

        [Test]
        public void ManyMultiplier()
        {
            var random = new Random();
            var i = random.Next();
            var j = random.Next();

            var route = new DirectRoute();
            var value = route.Get<int>("Many/Multiplier", i, j);

            Assert.AreEqual(i * j, value);
        }
    }
}