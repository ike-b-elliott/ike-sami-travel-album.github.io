using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAlbum.Data
{
    public class TripAlbumContext : DbContext
    {
        private const string ConnectionString = "Data Source=tripalbum.db";

        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripPhoto> TripPhotos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(ConnectionString);

        public TripAlbumContext(DbContextOptions<TripAlbumContext> options)
            : base(options) { }
    }
    
}
