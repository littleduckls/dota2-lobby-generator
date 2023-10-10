using dota2LobbyGenerator.Entities;

namespace dota2LobbyGenerator.Services.Interfaces
{
    public interface IHeroService
    {
        //crud
        Task CreateHero(Hero hero);
        Task<List<Hero>> GetAllHeroes();
        Task<Hero> GetHeroById(int id);
        Task UpdateHero(Hero hero);
        Task DeleteHero(Hero hero);
    }
}
