


using Log.WebApi.Mssql.Data.Db;

namespace Log.WebApi.Mssql.Data.SingletonContext
{

    public class SingletonContext
    {
        private static MssqlLogContext _mContext;
        private static object _lockObject = new object();

        private SingletonContext()
        {

        }

        public static MssqlLogContext GetInstance()
        {
            lock (_lockObject)
            {
                if (_mContext == null)
                {
                    _mContext = new MssqlLogContext();
                }
            }
            return _mContext;
        }
    }





}