using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaxIMDB.Models
{
    [Table("Movie_Actor")]
    public class MovieActorModel
    {
        [Key]
        [Column]
        public int Movie_Actor_Id { get; set; }

        [Required]
        [ForeignKey("MovieList")]
        [DisplayName("Movie")]
        [Column]
        public int Movie_Id { get; set; }

        [Required]
        [ForeignKey("ActorList")]
        [DisplayName("Actor")]
        [Column]
        public int Actor_Id { get; set; }

        public virtual MovieModel MovieList { get; set; }
        public virtual ActorModel ActorList { get; set; }
    }
}