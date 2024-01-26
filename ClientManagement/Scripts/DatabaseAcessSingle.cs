using System.Threading;
namespace ClientManagement
{
    public class DatabaseAcessSingle
    {
        private static SQLQueryUser.DatabaseManager _instance;
        private static readonly ReaderWriterLockSlim lockSlim = new ReaderWriterLockSlim();
        
        public DatabaseAcessSingle() { }
        public DatabaseAcessSingle(SQLQueryUser.DatabaseManager database)
        {
            Instance = database;
        }

        public static SQLQueryUser.DatabaseManager Instance
        {
            get
            {
                try
                {
                    lockSlim.EnterReadLock();
                    if (_instance == null)
                    {
                        return null;
                    }
                    return _instance;
                }
                finally
                {
                    lockSlim.ExitReadLock();
                }

            }
            private set
            {


                if (_instance == null)
                {
                    try
                    {
                        lockSlim.EnterWriteLock();
                        if (_instance == null)
                        {
                            _instance = value;
                        }
                    }
                    finally
                    {
                        lockSlim.ExitWriteLock();
                    }
                   
                    


                }
            }
        }
    }
}

