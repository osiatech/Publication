
using Microsoft.EntityFrameworkCore;
using Publication.Domain.Entities;

namespace Publication.Infrastructure.Context
{
    public class PublicationContext : DbContext
    {
        public PublicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Job> Jobs { get; set; }
        public DbSet<PublicationInformation> PublicationInformations { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<RoySched> RoyScheds { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<TitleAuthor> TitleAuthors { get; set; } 
    }
}
