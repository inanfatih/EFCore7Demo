namespace EFCore7Demo
{
    public class Character
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        
        public string RpgClass { get; set; } = "Knight";

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
