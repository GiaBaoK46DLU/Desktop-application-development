using System.Runtime.Caching;

namespace BusinessLogic
{
    public class BUS_MemoryCache
    {
        public static MemoryCache Cache = MemoryCache.Default;
    }
}
