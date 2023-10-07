using dota2LobbyGenerator.Data.Interfaces;
using dota2LobbyGenerator.Entities;
using Microsoft.EntityFrameworkCore;

namespace dota2LobbyGenerator.Data.Repos
{
    public class HeroRepository : IHeroRepository
    {
        private readonly DataContext _dataContext;
        public HeroRepository(DataContext dataContext)
        {
            _dataContext = dataContext;   
        }
        public async Task Create(Hero hero)
        {
            try
            {
                _dataContext.Heroes.Add(hero);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Delete(Hero hero)
        {
            try
            {
                _dataContext.Heroes.Remove(hero);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Hero>> GetAll()
        {
            return await _dataContext.Heroes.ToListAsync();
        }

        public Task<Hero> GetById(int id)
        {
            return _dataContext.Heroes.AsNoTracking().FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task Update(Hero hero)
        {
            try
            {
                _dataContext.Heroes.Update(hero);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
