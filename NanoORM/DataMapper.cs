using System.Collections.Generic;

namespace NanoORM
{
    public interface IMapper<Entity>
    {
        string connectionString { get; set; }
        void Save(Entity entity);
        void Delete(Entity entity);
        Dictionary<string, object> GetById(int id);
    }

    public abstract class DataMapper<Entity> : IMapper<Entity>
    {
        public string connectionString { get; set; }

        public DataMapper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public abstract Dictionary<string, object> GetById(int id);
        public abstract Dictionary<string, object> Fetch(Dictionary<string, object> whereArgs);
        public abstract void Save(Entity entity);
        public abstract void Delete(Entity entity);
    }
}
