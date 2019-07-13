using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace DeltaxIMDB.Models
{
    [Table("Actor")]
    public class ActorModel
    {
        [Key]
        [Column]
        public int Actor_Id { get; set; }

        [Required]
        [RegularExpression("^[\a-zA-Z]*$", ErrorMessage = "Enter Only Alphabets")]
        [StringLength(50, ErrorMessage = "Name must be string with a maximum length of 50.")]
        [DisplayName("Name")]
        [Column]
        public string Actor_Name { get; set; }

        [StringLength(200)]
        [DisplayName("Photo")]
        [Column]
        public string Actor_Photo { get; set; }

        [Required]
        [DisplayName("Gender")]
        [Column]
        public string Actor_Sex { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [DisplayName("DOB")]
        [Column]
        public DateTime Actor_DOB { get; set; }

        [Required]
        [StringLength(1000)]
        [DisplayName("Bio")]
        [Column]
        public string Actor_Bio { get; set; }

        [Required]
        [RegularExpression("^[\0-9']*$", ErrorMessage = "Only numbers and ' are allowed.")]
        [StringLength(10)]
        [DisplayName("Height")]
        [Column]
        public string Actor_Height { get; set; }

        [Required]
        [RegularExpression("^[\a-zA-Z]*$", ErrorMessage = "Enter Only Alphabets.")]
        [StringLength(50)]
        [DisplayName("Birth Name")]
        [Column]
        public string Actor_Birth_Name { get; set; }

        [Required]
        [RegularExpression("^[\a-zA-Z]*$", ErrorMessage = "Enter Only Alphabets.")]
        [StringLength(25)]
        [DisplayName("Birth State")]
        [Column]
        public string Actor_Birth_State { get; set; }

        [NotMapped]
        public HttpPostedFileBase Actor_Photo_Data { get; set; }


        public enum gender
        {
            Male,
            Female,
            Other
        }
    }
}