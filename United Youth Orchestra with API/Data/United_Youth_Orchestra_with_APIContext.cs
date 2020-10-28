using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using United_Youth_Orchestra_with_API.Models;

namespace United_Youth_Orchestra_with_API.Data
{
    public class United_Youth_Orchestra_with_APIContext : DbContext
    {
        public United_Youth_Orchestra_with_APIContext (DbContextOptions<United_Youth_Orchestra_with_APIContext> options)
            : base(options)
        {
        }

        public DbSet<United_Youth_Orchestra_with_API.Models.Member> Member { get; set; }
    }
}
