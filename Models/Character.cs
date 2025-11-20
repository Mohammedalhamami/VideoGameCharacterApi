namespace VideoGameCharacterApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Game { get; set; }
       
        public string Rule { get; set; } = "No special rules.";
    }
}
