using Microsoft.EntityFrameworkCore;
using Solutiuons.Budgeting.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutiuons.Budgeting.Web.Data
{
    public class BillContext : DbContext
    {
        public BillContext(DbContextOptions<BillContext> options)
            : base (options)
        {

        }

        public DbSet<Bill> Bills { get; set; }
    }
}
