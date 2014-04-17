using SQLite.Net.Interop;
using SQLite.Net.Platform.WindowsPhone8;

namespace SQLite.Net.Platform.WindowsPhone71
{
    public class SQLitePlatformWP71 : ISQLitePlatform
    {
        public SQLitePlatformWP71()
        {
            var api = new SQLiteApiWP8();

//            api.SetDirectory(/*temp directory type*/2, Windows.Storage.ApplicationData.Current.TemporaryFolder.Path);

            SQLiteApi = api;
            VolatileService = new VolatileServiceWP71();
            ReflectionService = new ReflectionServiceWP71();
            StopwatchFactory = new StopwatchFactoryWP71();
        }

        public ISQLiteApi SQLiteApi { get; private set; }
        public IStopwatchFactory StopwatchFactory { get; private set; }
        public IReflectionService ReflectionService { get; private set; }
        public IVolatileService VolatileService { get; private set; }
    }
}