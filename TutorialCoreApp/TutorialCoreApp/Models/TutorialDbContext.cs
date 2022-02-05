using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TutorialCoreApp.Models
{
    public class TutorialDbContext : DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext>options):base(options)
        {

        }
        public DbSet<Tutorial> tutorial { get; set; }
        //public DbSet<UserInfo>userinfo {get;set;}
    }
}
