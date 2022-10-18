using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagementSystem.Models.Entities
{
    public class EducationalInfo
    {
        public int EducationalInfoID { get; set; }
        [Display(Name = "Bachelor's Degree")]
        public string BDegree { get; set; }
        [Display(Name = "Marks")]
        public int BMarks { get; set; }
        [Display(Name = "Master's Degree")]
        public string MDegree { get; set; }
        [Display(Name = "Marks")]
        public int MMarks { get; set; }
        [Display(Name = "Additional Education/Course")]
        public string AEC { get; set; }
    }
}
