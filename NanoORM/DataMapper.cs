using System;
using System.Collections.Generic;

namespace NanoORM
{
    public interface IMapper<Entity>
    {
        string connectionString { get; set; }
        ICollection<IBinding> bindings { get; set; }
        void Save(Entity entity);
        void Delete(Entity entity);
        Entity GetById(int id);
    }

    public abstract class DataMapper<Entity> : IMapper<Entity>
    {
        public string connectionString { get; set; }

        public ICollection<IBinding> bindings { get; set; }

        public delegate Entity EntityBuilder(ICollection<IBinding> fields);

        public EntityBuilder Builder { get; set; }

        public DataMapper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataMapper(EntityBuilder Builder)
        {
            this.Builder = Builder;
        }

        public DataMapper(string connectionString, EntityBuilder Builder)
        {
            this.connectionString = connectionString;
            this.Builder = Builder;
        }

        public abstract Entity GetById(int id);
        public abstract void Save(Entity entity);
        public abstract void Delete(Entity entity);
    }
}
