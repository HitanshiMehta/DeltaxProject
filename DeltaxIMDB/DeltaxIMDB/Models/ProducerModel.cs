using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace DeltaxIMDB.Models
{
    [Table("Producer")]
    public class ProducerModel
    {
        [Key]
        [Column]
        public int Producer_Id { get; set; }

        [Required]
        [RegularExpression("^[\a-zA-Z]*$", ErrorMessage = "Enter Only Alphabets.")]
        [StringLength(50)]
        [DisplayName("Producer Name")]
        [Column]
        public string Producer_Name { get; set; }

        [StringLength(100)]
        [DisplayName("Photo")]
        [Column]
        public string Producer_Photo { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Gender")]
        [Column]
        public string Producer_Sex { get; set; }

        [Required]
        [DisplayName("DOB")]
        [Column(TypeName = "date")]
        public DateTime Producer_DOB { get; set; }

        [Required]
        [StringLength(400)]
        [DisplayName("Bio")]
        [Column]
        public string Producer_Bio { get; set; }

        [NotMapped]
        public HttpPostedFileBase Producer_Photo_Data { get; set; }

        public enum gender
        {
            Male,
            Female,
            Other
        }

    }
}