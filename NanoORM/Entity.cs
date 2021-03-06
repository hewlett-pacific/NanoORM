﻿using System.Collections.Generic;

namespace NanoORM
{
    public interface IEntity
    {
        int Id { get; }
        void SetFields(Dictionary<string, object> fields);
        IEntity GetEntity(int id);
    }

    public abstract class Entity<KeyType> : IEntity
    {
        private IMapper<IEntity> mapper;
        public int Id { get; }

        public abstract void SetFields(Dictionary<string, object> fields);
        public abstract IEntity GetEntity(int id);
        public void SetToDB()
        {
            this.mapper.Save(this);
        }
    }
}
