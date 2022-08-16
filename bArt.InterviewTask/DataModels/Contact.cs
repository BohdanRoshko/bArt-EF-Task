using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace bArt.InterviewTask.DataModels
{
    public class Contact
    {
        [Key]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? AccountName { get; set; }
        [JsonIgnore]
        public Account? Account { get; set; }
    }
}
