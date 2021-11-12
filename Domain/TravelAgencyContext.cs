using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TravelAgencyContext : DbContext
    {
        public DbSet<TuristickaAgencija> TuristickeAgencije { get; set; }
        public DbSet<Agent> Agenti { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
        public DbSet<Hotel> Hoteli { get; set; }
        public DbSet<Soba> Sobe { get; set; }
        public DbSet<StavkaRezervacije> StavkeRezervacije { get; set; }
        public DbSet<Gost> Gosti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = TuristickaAgencija;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TuristickaAgencija>().HasData(new TuristickaAgencija {TuristickaAgencijaID=1, Naziv = "Sabra", Telefon = "068172121"});
            
        }


    }
}
