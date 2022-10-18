using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagementSystem.Models.Entities
{
    public class AddressInfo
    {
        public int AddressInfoID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [Display(Name = "Mail Id")]
        public string Email { get; set; }
        [Display(Name = "Alternate Mail Id")]
        public string AEmail { get; set; }
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
    }
}
