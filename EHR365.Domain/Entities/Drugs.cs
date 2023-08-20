using System.ComponentModel.DataAnnotations;

namespace EHR365.Domain.Entities
{
    public class Drugs
    {
        [Key]
        [Required(ErrorMessage ="Drug Id is a required field.")]
        public int DrugId { get; set; }

        [Required(ErrorMessage ="Drug Name is a required field.")]
        [MaxLength(100,ErrorMessage ="Maximum length for Drug Name is 100")]
        public string? DrugName { get; set; }

        [Required(ErrorMessage = "Description Name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for Description is 500")]
        public string? Description { get; set; }
    }
}