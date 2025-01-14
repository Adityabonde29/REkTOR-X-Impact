using dotnetapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<DonationRequest> DonationRequests { get; set; }
        public DbSet<DonationOffer> DonationOffers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DonationOffer>()
                .HasOne(dor => dor.User)
                .WithMany(u => u.DonationOffers)
                .HasForeignKey(dor => dor.UserId);

            // Organization to DonationRequest relationship
            modelBuilder.Entity<DonationRequest>()
                .HasOne(dr => dr.Organization)
                .WithMany(o => o.DonationRequests)
                .HasForeignKey(dr => dr.OrganizationId);
        }
    }
}