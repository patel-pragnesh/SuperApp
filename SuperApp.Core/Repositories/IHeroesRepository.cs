using System;
using System.Collections.Generic;
using SuperApp.Models;

namespace SuperApp.Core.Repositories
{
    public interface IHeroesRepository : IBaseRepository<Hero>
    {
        new Hero Get(string id);
        new List<Hero> Get();
        new bool Save(Hero hero);
    }
}
