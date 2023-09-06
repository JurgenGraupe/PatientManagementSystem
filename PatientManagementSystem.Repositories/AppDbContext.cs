using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatientManagementSystem.Repositories.DomainModels;

namespace PatientManagementSystem.Repositories {
    public class AppDbContext : IdentityDbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) {
        }

        internal DbSet<Debtor> Debtors { get; set; }
        internal DbSet<Patient> Patients { get; set; }
        internal DbSet<Account> Accounts { get; set; }
        internal DbSet<Invoice> Invoices { get; set; }
    }
}