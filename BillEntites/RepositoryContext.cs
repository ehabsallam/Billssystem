using System;
using System.Collections.Generic;
using System.Text;
using BillEntity.Model;
using Microsoft.EntityFrameworkCore;

namespace BillEntity
{
   public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<BILDTL> Bildtls { get; set; }
        public DbSet<BILHDR> Bilhdrs { get; set; }
        public DbSet<ITMDTL> Itmdtls { get; set; }
        public DbSet<VNDDTL> Vnddtls { get; set; }
    }
}
