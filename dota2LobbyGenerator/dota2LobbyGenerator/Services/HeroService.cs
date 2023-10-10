using dota2LobbyGenerator.Data.Interfaces;
using dota2LobbyGenerator.Entities;
using dota2LobbyGenerator.Services.Interfaces;

namespace dota2LobbyGenerator.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;
        public HeroService(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;      
        }
        public async Task CreateHero(Hero hero)
        {
            await _heroRepository.Create(hero); 
        }

        public async Task DeleteHero(Hero hero)
        {
            await _heroRepository.Delete(hero);
        }

        public async Task<List<Hero>> GetAllHeroes()
        {
            var heroes = await _heroRepository.GetAll();
            return heroes;  
        }

        public async Task<Hero> GetHeroById(int id)
        {
            var hero = await _heroRepository.GetById(id);
            return hero;    
        }

        public async Task UpdateHero(Hero hero)
        {
            await _heroRepository.Update(hero);   
        }
    }
}
