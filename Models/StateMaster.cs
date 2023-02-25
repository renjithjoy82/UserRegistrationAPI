using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAPI.Models
{
    public class StateMaster
    {
        [Key]
        public int StateId { get; set; }

        [StringLength(15)]
        public string StateName { get; set; } = string.Empty;
    }
}
