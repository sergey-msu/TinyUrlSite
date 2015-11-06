using System.Threading;
using NFX;
using NFX.DataAccess.MySQL;

namespace TinyUrlSite
{
    public static class SiteContext
    {
        private static long s_ID; 

        public static MySQLDataStore DataStore
        {
            get { return App.DataStore as MySQLDataStore; }
        }

        public static long NextId()
        {
            return Interlocked.Increment(ref s_ID);
        }
    }
}

