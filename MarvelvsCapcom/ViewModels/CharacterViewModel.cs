namespace MarvelvsCapcom.ViewModels
{
    public class CharacterViewModel
    {
        public int Id { get; set; }
        public string CharName { get; set; } = null!;
        public string? Side { get; set; }
        public int Ab1Id { get; set; }
        public int Ab2Id { get; set; }
        public int Ab3Id { get; set; }
        public int Ab4Id { get; set; }
        public int? HeathPoints { get; set; }

    }
}
