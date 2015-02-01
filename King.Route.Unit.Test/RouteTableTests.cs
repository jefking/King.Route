namespace King.Route.Unit.Test
{
    using King.Route;
    using NUnit.Framework;

    [TestFixture]
    public class RouteTableTests
    {
        [Test]
        public void Routes()
        {
            Assert.IsNotNull(RouteTable.Routes);
        }
    }
}