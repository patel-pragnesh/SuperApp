using SuperApp.Core.Repositories;
using SuperApp.Models;

namespace SuperApp.Repositories
{
    public class HeroesRepository : BaseRepository<Hero>, IHeroesRepository
    { }
}
