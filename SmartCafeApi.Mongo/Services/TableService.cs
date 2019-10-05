using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SmartCafeApi.Mongo.Models;

namespace SmartCafeApi.Mongo.Services
{
    public class TableService
    {
        private readonly IMongoCollection<Table> _tables;

        public TableService(ISmartCafeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _tables = database.GetCollection<Table>(settings.TablesCollectionName);
        }

        public List<Table> Get() =>
            _tables.Find(table => true).ToList();
    }
}
