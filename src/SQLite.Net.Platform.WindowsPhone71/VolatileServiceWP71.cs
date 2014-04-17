using SQLite.Net.Interop;

namespace SQLite.Net.Platform.WindowsPhone71
{
    public class VolatileServiceWP71 : IVolatileService
    {
        private readonly object _locker = new object();

        public void Write(ref int transactionDepth, int depth)
        {
            lock (_locker)
            {
                transactionDepth = depth;
            }
            //Volatile.Write(ref transactionDepth, depth);
        }
    }
}