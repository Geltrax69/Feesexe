using SQLite;
using System.IO;
using System.Threading.Tasks;
using SchoolFeesManager.Models;
using System;

namespace SchoolFeesManager.Services
{
    public class DatabaseService
    {
        private const string DbName = "SchoolFees.db3";
        private readonly string _dbPath;
        private SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _dbPath = Path.Combine(folder, "SchoolFeesManager", DbName);
            Directory.CreateDirectory(Path.GetDirectoryName(_dbPath));
        }

        public async Task InitializeAsync()
        {
            if (_database != null)
                return;

            _database = new SQLiteAsyncConnection(_dbPath);

            await _database.CreateTableAsync<Student>();
            await _database.CreateTableAsync<FeeStructure>();
            await _database.CreateTableAsync<StudentFee>();
            await _database.CreateTableAsync<Payment>();
            // await _database.CreateTableAsync<LedgerEntry>();
        }

        public SQLiteAsyncConnection GetConnection() => _database;
    }
}
