using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAPI.Models
{
    public class UserMaster
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public Nullable<DateTime> DateofBirth { get; set; }

        public string? Address { get; set; }

        public Nullable<int> StateId { get; set; }

        public StateMaster? State { get; set; }
    }
}
