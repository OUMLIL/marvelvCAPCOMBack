namespace MarvelvsCapcom.ViewModels
{
    public class AttaqueViewModel
    {
        public UserViewModel AttackedPlayer { get; set; }
        public CharacterViewModel AttackedPlayerCharacter { get; set; }
        public AbilityViewModel attack { get; set; }
    }
}
