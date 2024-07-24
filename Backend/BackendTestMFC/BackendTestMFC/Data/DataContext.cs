using BackendTestMFC.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendTestMFC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ms_storage_location> ms_storage_location { get; set; }
        public DbSet<ms_user> ms_user { get; set; }
        public DbSet<tr_bpkb> tr_bpkb { get; set; }
    }
}
