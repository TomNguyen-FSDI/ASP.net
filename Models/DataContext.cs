using Microsoft.EntityFrameworkCore;

namespace Task_Manager.Models
{
    public class DataContext : DbContext
    {
        /*
        Everytime you change something on the models, run these:
            - dotnet ef migrations add <someName>
                example: dotnet ef migrations add initial
            - dotnet ef database update
        */

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //which of my models should become tables in the DB?
        public DbSet<Task> Tasks
        {
            get;
            set;
        }
        //public DbSet<User> Users{get;set;}
    }
}
