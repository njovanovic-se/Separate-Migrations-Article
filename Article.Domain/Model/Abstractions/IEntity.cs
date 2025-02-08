using System.ComponentModel.DataAnnotations;

namespace Article.Domain.Model.Abstractions
{
    public abstract record Entity<K> where K : struct
    {
        [Key]
        public K Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
