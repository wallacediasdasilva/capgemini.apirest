namespace RestAPI
{
    public class AnimalModel
    {
        public AnimalModel(int id, int qtd, string species, string name)
        {
            Id = id;
            Qtd = qtd;
            Species = species;
            Name = name;
        }

        public int Id { get; set; }

        public int Qtd { get; set; }

        public string Species { get; set; }

        public string Name { get; set; }
    }
}
