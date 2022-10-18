using HumanResourceManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagementSystem.Models.Data
{
    public class HRMSystemDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HRMSystemDb2022;Integrated Security=True");
        }
        DbSet<Employee> employees { get; set; }
        DbSet<PersonalInfo> personalInfo { get; set; }
        DbSet<AddressInfo> addressInfo { get; set; }
        DbSet<EducationalInfo> educationalInfo { get; set; }
        DbSet<CivilInfo> civilInfo { get; set; }
        DbSet<OfficialInfo> officialInfo { get; set; }
    }
}
