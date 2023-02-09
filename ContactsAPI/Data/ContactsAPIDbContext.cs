using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        //in the db context we have to create properties act as tables
        public DbSet<Contact> Contacts { get; set; }//because only have on model;dbset property of type contact;and call property contacts
    }
}
