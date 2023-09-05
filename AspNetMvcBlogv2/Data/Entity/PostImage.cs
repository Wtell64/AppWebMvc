using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcBlogv2.Data.Entity
{
    public class PostImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
		[MaxLength(255)]
		public string ImageUrl { get; set; }


        //Relationships
        public Post Post { get; set; }

        [ForeignKey(nameof(Post))]
        public Guid PostId { get; set; }
    }
}
