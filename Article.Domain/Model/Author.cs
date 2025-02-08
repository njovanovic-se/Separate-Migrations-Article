using Article.Domain.Model.Abstractions;

namespace Article.Domain.Model
{
    public record Author : Entity<Guid>
    {
        public string Username { get; set; } = default!;
    }
}
