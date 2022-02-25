namespace MarvelvsCapcom.ViewModels
{
    public class AbilityViewModel
    {
        public int Id { get; set; }
        public string AbName { get; set; } = null!;
        public int CoolDown { get; set; }
        public int Damage { get; set; }
    }
}
