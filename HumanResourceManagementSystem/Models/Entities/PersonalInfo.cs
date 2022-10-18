using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagementSystem.Models.Entities
{
    public class PersonalInfo
    {
        public int PersonalInfoID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } 
    }
}
