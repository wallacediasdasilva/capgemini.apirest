using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ZooController : ControllerBase
    {
        public ZooController()
        {
        }

        [HttpGet]
        public AnimalModel Get()
        {
            AnimalModel animal = new AnimalModel()
            {
                Id = 1,
                Name = "Leão",
                Species = "Panthera leo",
                Qtd = 1
            };

            return animal;
        }

        [HttpGet]
        public List<AnimalModel> GetList()
        {
            return new List<AnimalModel>
            {
                new AnimalModel(){ Id = 1, Name = "Leão", Species = "Panthera leo", Qtd = 1},
                new AnimalModel(){ Id = 2, Name = "Raposa", Species = "Raposa-vermelha", Qtd = 1}
            };
        }

        [HttpPost]
        public IActionResult Post([FromBody] AnimalModel animal)
        {
            var animalPost = new AnimalModel()
            {
                Id = animal.Id,
                Name = animal.Name,
                Species = animal.Species,
                Qtd = animal.Qtd
            };

            return Ok(animalPost);
        }

        [HttpPut]
        public IActionResult Put([FromBody] AnimalModel animal)
        {
            var animalPost = new AnimalModel()
            {
                Id = animal.Id,
                Name = animal.Name,
                Species = animal.Species,
                Qtd = animal.Qtd
            };

            return Ok(animalPost);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] AnimalModel animal)
        {
            var animalPost = new AnimalModel()
            {
                Name = animal.Name,
            };

            return Ok(animalPost);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
