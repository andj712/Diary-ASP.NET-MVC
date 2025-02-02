using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int  Id { get; set; }
        [Required] //title is required
        public String Title { get; set; } = string.Empty;

        [Required]
        public String Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; }
    }
}
