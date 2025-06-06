﻿using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int  Id { get; set; }
        [Required(ErrorMessage ="Please enter the title")] //title is required
        [StringLength(100,MinimumLength =3,ErrorMessage ="Title must be between 3 and 100 characters!")]
        public String Title { get; set; } = string.Empty;

        [Required]
        public String Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; }
    }
}
