using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLDemo
{
    public class AzureDataService
    {
        public ITableDataStore<Cache> cacheTable;
        private const string LOCAL_SQLITE_STORE_PATH = "syncstore.db";

        public AzureDataService(string azureMobileAppURL)
        {
            // Create Client
            var mobileService = EasyMobileServiceClient.Create();
            mobileService.Initialize(azureMobileAppURL);

            // Register the data model to create the table with
            mobileService.RegisterTable<Cache>();
            mobileService.FinalizeSchema();
            cacheTable = mobileService.Table<Cache>();
        }

        public Task<IEnumerable<Cache>> GetCaches() => cacheTable.GetItemsAsync();

        public Task<bool> AddCache(Cache cache)
        {
            return cacheTable.AddAsync(cache);
        }

        //pull down all latest changes and then push current caches up; Is this necessary???
        // public Task<string> SyncCaches() {}
    }
}
