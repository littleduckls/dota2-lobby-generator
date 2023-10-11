using dota2LobbyGenerator.Entities;

namespace dota2LobbyGenerator.Data.Interfaces
{
    public interface IHeroRepository
    {
        //crud
        Task Create(Hero hero);
        Task<List<Hero>> GetAll();
        Task<Hero> GetById(int id);
        Task Update(Hero hero);
        Task Delete(Hero hero);   
        Task<List<Hero>> GetHeroesByAtribute(string atribute);
    }
}
