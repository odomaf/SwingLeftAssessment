using System.ComponentModel.DataAnnotations;

namespace SwingLeftAssessment.Models
{
  public class voter_registration_deadlines
  {
    //public string Id { get; set; }
    [Key]
    public string State { get; set; }
    public string DeadlineInPerson { get; set; }
    public string DeadlineByMail { get; set; }
    public string DeadlineOnline { get; set; }
    public string ElectionDayRegistration { get; set; }
    public string OnlineRegistrationLink { get; set; }
    public string Description { get; set; }
    
  }
}
