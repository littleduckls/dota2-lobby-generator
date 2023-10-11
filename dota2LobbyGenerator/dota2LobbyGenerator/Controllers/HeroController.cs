using dota2LobbyGenerator.DTOS;
using dota2LobbyGenerator.Entities;
using dota2LobbyGenerator.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dota2LobbyGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;      
        }

        [HttpPost]
        public async Task<ActionResult> CreateHero(CreateHeroDTO request)
        {
            Hero hero = new Hero();
            hero.Name = request.Name;
            hero.Atribute = request.Atribute;
            
            await _heroService.CreateHero(hero);

            return Ok("hero adicionado com sucesso");
        }

        [HttpPatch]
        public async Task<ActionResult> UpdateHero(UpdateHeroDTO request)
        {
            var hero = await _heroService.GetHeroById(request.Id);
            if (hero == null)
            {
                return NotFound("hero não encontrado :(");
            }

            hero.Name = request.Name;
            hero.Atribute = request.Atribute;
            await _heroService.UpdateHero(hero);

            return Ok("hero atualizado com sucesso :)");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHero(int id)
        {
            var hero = await _heroService.GetHeroById(id);
            if (hero == null)
            {
                return NotFound("hero não encontrado");
            }

            await _heroService.DeleteHero(hero);

            return Ok("hero deletado com sucesso");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetHero(int id)
        {
            var hero = await _heroService.GetHeroById(id);
            return Ok(hero);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllHeroes()
        {
            var heroes = await _heroService.GetAllHeroes();
            return Ok(heroes);
        }
    }
}
