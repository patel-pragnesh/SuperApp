using System;
using System.Collections.Generic;
using SuperApp.Models;

namespace SuperApp.Core.Repositories
{
    public interface ISkillsRepository : IBaseRepository<Skill>
    {
        new Skill Get(string id);
        new List<Skill> Get();
        new bool Save(Skill skill);
    }
}
