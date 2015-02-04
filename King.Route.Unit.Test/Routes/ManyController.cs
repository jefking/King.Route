namespace King.Route.Unit.Test.Routes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [RouteAlias("Many")]
    public class ManyController
    {
        [RouteAlias("Multiplier")]
        public int Get(int i, int j)
        {
            return i * j;
        }
    }
}