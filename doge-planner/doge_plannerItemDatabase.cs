using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace doge_planner
{
    public static doge_plannerItemDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new doge_plannerItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("doge_plannerSQLite.db3"));
            }
            return database;
        }

        readonly SQLiteAsyncConnection database;

        public doge_plannerItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<doge_plannerItem>().Wait();
        }

    public Task<List<doge_plannerItem>> GetItemsAsync()
    {
        return database.Table<doge_plannerItem>().ToListAsync();
    }

    public Task<List<doge_plannerItem>> GetItemsNotDoneAsync()
    {
        return database.QueryAsync<doge_plannerItem>("SELECT * FROM [doge_plannerItem] WHERE [Done] = 0");
    }

    public Task<doge_plannerItem> GetItemAsync(int id)
    {
        return database.Table<doge_plannerItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
    }

    public Task<int> SaveItemAsync(doge_plannerItem item)
    {
        if (item.ID != 0)
        {
            return database.UpdateAsync(item);
        }
        else
        {
            return database.InsertAsync(item);
        }
    }

    public Task<int> DeleteItemAsync(doge_plannerItem item)
    {
        return database.DeleteAsync(item);
    }

}
}