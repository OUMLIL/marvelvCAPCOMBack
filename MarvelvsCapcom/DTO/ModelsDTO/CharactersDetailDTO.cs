namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public class CharactersDetailDTO
    {
        public int Id { get; set; }
        public string CharName { get; set; } = null!;
        public string? Side { get; set; }
        public AbilityDTO Ab1 { get; set; }
        public AbilityDTO Ab2 { get; set; }
        public AbilityDTO Ab3 { get; set; }
        public AbilityDTO Ab4 { get; set; }

        public int Ab1Id { get; set; }
        public int Ab2Id { get; set; }
        public int Ab3Id { get; set; }
        public int Ab4Id { get; set; }
        public int? HeathPoints { get; set; }
    }
}
