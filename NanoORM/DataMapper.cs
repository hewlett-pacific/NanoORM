using System.Collections.Generic;

namespace NanoORM
{
    public interface IMapper
    {
        void Save(IEntity entity);
        void Delete(IEntity entity);
        Dictionary<string, object> GetByKey(object id);
    }

    public abstract class DataMapper<Entity> : IMapper
    {
        protected System.Data.IDbConnection connection;

        public abstract Dictionary<string, object> GetByKey(object id);
        public abstract Dictionary<string, object> FetchBy(Dictionary<string, object> whereArgs);
        public abstract void Save(IEntity entity);
        public abstract void Delete(IEntity entity);
    }
}
