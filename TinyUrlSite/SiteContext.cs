using NFX;
using NFX.DataAccess.MySQL;

namespace TinyUrlSite
{
    public static class SiteContext
    {
        #region CONSTS

        private const string SCRIPT_ASM = "TinyUrlSite";
        private const string HANDLER_ASM = "TinyUrlSite, TinyUrlSite";

        #endregion

        private static readonly MySQLDataStore s_DataStore;

        static SiteContext()
        {
            s_DataStore = (MySQLDataStore)App.DataStore;
            s_DataStore.QueryResolver.ScriptAssembly = SCRIPT_ASM;
            s_DataStore.QueryResolver.RegisterHandlerLocation(HANDLER_ASM);
        }

        public static MySQLDataStore DataStore
        {
            get { return s_DataStore; }
        }
    }
}