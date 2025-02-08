using Article.Domain.Model.Abstractions;

namespace Medium.Separating.Migrations.Domain.Model
{
    public record Blog : Entity<Guid>
    {
        public string Url { get; set; } = default!;
        public int Rating { get; set; }
        public List<Post> Posts { get; set; } = [];
    }
}
