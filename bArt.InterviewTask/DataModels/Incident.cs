namespace bArt.InterviewTask.DataModels
{
    public class Incident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public string IncidentName { get; set; }
        public string? IncidentDescription { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
