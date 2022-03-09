using MarvelvsCapcom.DTO.ModelsDTO;

namespace MarvelvsCapcom.ViewModels
{
    public class GameViewModel
    {
        public UserDTO User1 { get; set; }
        public CharacterViewModel[] p1_characs { get; set; }
        public UserDTO User2 { get; set; }
        public CharacterViewModel[] p2_characs { get; set; }

        public GameViewModel()
        {
            /*this.p1_characs = new CharacterViewModel[3];
            this.p2_characs = new CharacterViewModel[3];*/
        }
    }
}
