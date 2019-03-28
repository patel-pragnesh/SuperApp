using System;
using System.Collections.Generic;
using Couchbase.Lite;
using SuperApp.Core.Repositories;

namespace SuperApp.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        const string DatabaseName = "SuperApp";

        Database _database;
        protected Database Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new Database(DatabaseName);
                }

                return _database;
            }
            private set => _database = value;
        }

        protected BaseRepository()
        { }

        public void Dispose()
        {
            Database.Close();
            Database = null;
        }

        public T Get(string id)
        {
            T obj = default(T);

            var document = Database.GetDocument(id);

            if (document != null)
            {
                obj = document.ToObject<T>();
            }

            return obj;
        }

        public List<T> Get()
        {
            // TODO: Get all of the things.

            return new List<T>();
        }

        public bool Save(T obj)
        {
            var mutableDocument = obj.ToMutableDocument();

            if (mutableDocument != null)
            {
                Database.Save(mutableDocument);

                return true;
            }

            return false;
        }
    }
}
