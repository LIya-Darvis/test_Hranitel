using HranitelPRO_api.Models;
using Microsoft.EntityFrameworkCore;

namespace HranitelPRO_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupVisit> GroupVisits { get; set; }
        public DbSet<GroupVisitApplication> GroupVisitApplications { get; set; }
        public DbSet<IndividualVisit> IndividualVisits { get; set; }
        public DbSet<IndividualVisitApplication> IndividualVisitApplications { get; set; }
        public DbSet<PassGoal> PassGoals { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<User> Users { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<in>()
        // }
        
        

    }
}

