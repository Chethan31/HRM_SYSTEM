namespace HumanResourceManagementSystem.Models.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public int AddressInfoID { get; set; }
        public EducationalInfo EducationalInfo { get; set; }
        public int EducationalInfoID { get; set; }
        public CivilInfo CivilInfo { get; set; }
        public int CivilInfoID { get; set; }
        public OfficialInfo OfficialInfo { get; set; }
        public int OfficialInfoID { get; set; }

    }
}
