using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlogv2.Data.Entity
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string Title { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(5, ErrorMessage = "{0} en az {1} harf olmali")]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishedAt { get; set; } = DateTime.Now;
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Relationship
        public ICollection<CategoryPost> CategoryPosts { get; set; }
        public ICollection<PostComment> Comments { get; set; }
        public ICollection<PostImage> Images { get; set; }
    }
}
