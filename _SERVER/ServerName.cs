using SYS_MODELS;

namespace _SERVER
{
    public class ServerName
    {
        public static IDbName Database = new RealDb();
        //public static IDbName Database = new FakeDb();
    }
}
