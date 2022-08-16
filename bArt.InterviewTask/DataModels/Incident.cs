using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace bArt.InterviewTask.DataModels
{
    public class Incident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IncidentName { get; set; }
        public string? IncidentDescription { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
