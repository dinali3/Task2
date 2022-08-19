using Task2.Models;
using Microsoft.EntityFrameworkCore;

namespace Task2.Data
{
    public class ContactsAPIDbContext: DbContext
    {
        
        public ContactsAPIDbContext(DbContextOptions options):base(options)
            {

            }
        public DbSet<Contact> Contacts
        {
            get; set; 
        }

    }
}
