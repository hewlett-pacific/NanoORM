using System.Collections.Generic;

namespace NanoORM
{
    public interface IEntity<KeyType>
    {
        KeyType key { get; set; }
        void SetFields(ICollection<IBinding> bindings);
        ICollection<IBinding> GetFields();
    }

    public abstract class Entity<KeyType> : IEntity<KeyType>
    {
        public KeyType key { get; set; }
        public Entity(KeyType key)
        {
            this.key = key;
        }

        public abstract void SetFields(ICollection<IBinding> bindings);
        public abstract ICollection<IBinding> GetFields();
    }
}
