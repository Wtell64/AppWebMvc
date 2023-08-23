using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlogv2.Data.Entity
{
    public class PostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(400, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string Content { get; set; }

        [ForeignKey(nameof(Post))]
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
