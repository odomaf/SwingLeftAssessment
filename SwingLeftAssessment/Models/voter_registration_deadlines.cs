using System.ComponentModel.DataAnnotations;

namespace SwingLeftAssessment.Models
{
    public class voter_registration_deadlines
    {
        //public string Id { get; set; }
        [Key]
        public string state { get; set; }
        public string deadlineinperson { get; set; }
    }
}
