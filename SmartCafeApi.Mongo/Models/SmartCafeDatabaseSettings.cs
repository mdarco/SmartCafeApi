using System;

namespace SmartCafeApi.Mongo.Models
{
    public class SmartCafeDatabaseSettings : ISmartCafeDatabaseSettings
    {
        public string TablesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISmartCafeDatabaseSettings
    {
        string TablesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
