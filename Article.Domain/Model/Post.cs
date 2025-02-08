using Article.Domain.Model.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medium.Separating.Migrations.Domain.Model
{
    public record Post : Entity<Guid>
    {
        public string Title { get; set; } = default!;
        public string Content { get; set; } = default!;

        [ForeignKey(nameof(Blog))]
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; } = default!;
    }
}
