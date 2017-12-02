using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLDemo
{
    public class CacheListViewModel
    {
        public List<Cache> Caches;

        public CacheListViewModel()
        {
            Caches = new List<Cache>
            {
                new Cache("Line 1", "I sit beside the window and think", true),
                new Cache("Line 2", "of all that I have seen.", true),
                new Cache("Line 3", "Of meadow-flowers and butterflies", false),
                new Cache("Line 4", "In summers that have been;", true)
            };
        }

    }
}
