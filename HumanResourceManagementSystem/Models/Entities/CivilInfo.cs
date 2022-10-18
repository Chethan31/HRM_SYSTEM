using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagementSystem.Models.Entities
{
    public class CivilInfo
    {
        public int CivilInfoID { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "PAN Card No")]
        public string PanCard { get; set; }
    }
}
