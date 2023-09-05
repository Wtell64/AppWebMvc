using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlogv2.Data.Entity
{
    public class Setting
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(5)]
        public string Name { get; set; }

		    [Required]
		    [MaxLength(255)]
		    public string Value { get; set; }

    }
}
