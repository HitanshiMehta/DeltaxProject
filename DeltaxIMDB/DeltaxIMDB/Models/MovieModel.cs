using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace DeltaxIMDB.Models
{
    [Table("Movie")]
    public class MovieModel
    {
        [Key]
        [Column]
        public int Movie_Id { get; set; }

        [Required]
        [RegularExpression("^[\a-zA-Z0-9]*$", ErrorMessage = "Enter Only Alphabets and Numbers.")]
        [StringLength(50)]
        [DisplayName("Movie Name")]
        [Column]
        public string Movie_Name { get; set; }

        [Required]
        [StringLength(4)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter Only Numbers.")]
        [DisplayName("Release Year")]
        [Column]
        public string Movie_Release_Year { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Plot")]
        [Column]
        public string Movie_Plot { get; set; }

        [StringLength(100)]
        [DisplayName("Poster")]
        [Column]
        public string Movie_Poster { get; set; }

        [Required]
        [Range(0, 10)]
        [RegularExpression("^[0-9].*$", ErrorMessage = "Enter Only Numbers.")]
        [DisplayName("Rating")]
        [Column]
        public double Movie_Rating { get; set; }

        [Required]
        [ForeignKey("ProducerList")]
        [DisplayName("Producer")]
        [Column]
        public int Producer_Id { get; set; }

        [NotMapped]
        public HttpPostedFileBase Movie_Photo_Data { get; set; }


        public virtual ProducerModel ProducerList { get; set; }

    }
}