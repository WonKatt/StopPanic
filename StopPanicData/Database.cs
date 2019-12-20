using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using StopPanic.Data.Entities;

namespace StopPanic.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<PanicCalendarRecord>().Wait();
        }

        public Task<List<PanicCalendarRecord>> GetPanicCalendarRecordAsync()
        {
            return _database.Table<PanicCalendarRecord>().ToListAsync();
        }

        public Task<int> SavePanicCalendarRecordAsync(PanicCalendarRecord record)
        {
            return _database.InsertAsync(record);
        }
    }
}
