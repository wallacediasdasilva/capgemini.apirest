using Microsoft.AspNetCore.Mvc;
using RestAPI.Repository;
using System.Collections.Generic;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ZooController : ControllerBase
    {
        private readonly List<AnimalModel> animalModels = new List<AnimalModel>();
        private readonly ZooRepository _zooRepository = new ZooRepository();

        public ZooController()
        {
            animalModels.AddRange(_zooRepository.Populate());
        }

        [HttpGet("{Id}")]
        public AnimalModel Get([FromQuery] int Id)
        {
            return animalModels.Find(e => e.Id == Id);
        }

        [HttpGet]
        public List<AnimalModel> GetList()
        {
            return animalModels;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AnimalModel animal)
        {
            animalModels.Add(new AnimalModel(animal.Id, animal.Qtd, animal.Species, animal.Name));

            return Created("", new ObjectResult(animalModels));
        }

        [HttpPut]
        public IActionResult Put([FromBody] AnimalModel animal)
        {
            var item = animalModels.Find(e => e.Id == animal.Id);
            animalModels.Remove(item);

            item.Name = animal.Name;
            item.Qtd = animal.Qtd;
            item.Species = animal.Species;

            animalModels.Add(item);

            return Ok(animal);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] AnimalModel animal)
        {
            var item = animalModels.Find(e => e.Id == animal.Id);
            animalModels.Remove(item);

            item.Name = animal.Name;
            item.Qtd = animal.Qtd;
            item.Species = animal.Species;

            animalModels.Add(item);

            return Ok(animal);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromQuery] int Id)
        {
            return Ok(animalModels.Remove(animalModels.Find(e => e.Id == Id)));
        }
    }
}
