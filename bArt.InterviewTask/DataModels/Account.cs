namespace bArt.InterviewTask.DataModels
{
    public class Account
    {
        [Key]
        public string Name { get; set; }
        public string? IncidentName { get; set; }
        [JsonIgnore]
        public Incident? Incident { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
