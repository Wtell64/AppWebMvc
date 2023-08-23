using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlogv2.Data.Entity
{
    public class CategoryPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Post))]
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
