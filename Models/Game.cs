namespace aspCourses.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Game(int id, string? name = default, string? description = default)
        {
            Id = id;
            Name = name ?? "New Game";
            Description = description ?? string.Empty;
        }
    }
}
