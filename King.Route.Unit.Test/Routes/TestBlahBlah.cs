namespace King.Route.Unit.Test.Routes
{
    using King.Route;

    /// <summary>
    /// Test Controller without Controller in the name
    /// </summary>
    public class TestBlahBlah : IRoutableController
    {
        private static volatile int data = 0;

        public int Get()
        {
            return data;
        }

        [RouteAlias("Blue")]
        public void Set(int id)
        {
            data = id;
        }
    }
}
