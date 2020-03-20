using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.DbModels
{
    public class DataBaseServiceContext : DbContext
    {
        public DataBaseServiceContext() 
            : base()
        {
        }

        public DbSet<DbUser> Users { get; set; }
    }
}
