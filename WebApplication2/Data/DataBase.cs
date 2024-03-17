using Microsoft.EntityFrameworkCore;
using WebAppCrud.Models;

namespace WebAppCrud.Data
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options) : base(options) { }
       public DbSet<Numbers> NumberTable { get; set; }

    }
}
