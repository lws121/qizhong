using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [StringLength(300)]
        [Required]
        public string Name { get; set; }


        [Display(Name = "性别")]
        [Required]
        [StringLength(1)]
        public string Gender { get; set; }


        [Display(Name = "年龄")]
        [Range(1, 200)]
        public int Age { get; set; }


        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "手机号码")]
        [RegularExpression(@"^[0-9""'\s-]*$")]
        [StringLength(13, MinimumLength = 13)]
        [Required]
        public string Phone { get; set; }


        [Display(Name = "体温")]
        [Range(30, 50)]
        [Required]
        public string Temperature { get; set; }

        [Display(Name = "填表日期")]
        public DateTime Date { get; set; }

    }
}
