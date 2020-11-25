using System.Collections.Generic;

namespace RestAPI.Repository
{
    public class ZooRepository
    {
        internal IEnumerable<AnimalModel> Populate()
        {
            List<AnimalModel> animalModels = new List<AnimalModel>
            {
                new AnimalModel(1, 2, "Raposa", "Raposa-vermelha"),
                new AnimalModel(1, 2, "Leão", "Panthera leo"),
                new AnimalModel(1, 2, "Leoa", "Panthera leo")
            };

            return animalModels;
        }
    }
}
