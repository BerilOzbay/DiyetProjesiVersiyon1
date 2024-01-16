using _01DiyetProjesi.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Context.EF
{
    public class EfDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LAQPBG1\MSSQLSERVER02;Database=DiyetProjesi;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
