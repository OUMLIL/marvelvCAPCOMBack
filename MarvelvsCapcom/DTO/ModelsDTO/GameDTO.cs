namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public class GameDTO
    {
        UserDTO user1 { get; set; }
        CharactersDetailDTO[] user1Characters = new CharactersDetailDTO[3];

        UserDTO user2 { get; set; }
        CharactersDetailDTO[] user2Characters = new CharactersDetailDTO[3];

        public GameDTO()
        {
            this.user1 = new UserDTO();
            this.user2 = new UserDTO();
            this.user1Characters = new CharactersDetailDTO[3];
            this.user2Characters = new CharactersDetailDTO[3];   
        }

    }
}
