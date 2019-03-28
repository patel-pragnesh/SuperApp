using System;
using System.Collections.Generic;

namespace SuperApp.Core.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        T Get(string id);
        List<T> Get();
        bool Save(T obj);
    }
}
