using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TDTBaiThiLai.Data
{
    public class TDT642 : DbContext
    {
        public TDT642 (DbContextOptions<TDT642> options): base(options)
        {}

        public DbSet<TDTBaiThiLai.Models.TDT642> TDT642s { get; set; }
    }
}