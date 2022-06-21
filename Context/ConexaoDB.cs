using exemploAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploAPI.Context
{
    public class ConexaoDBS : DbContext
    {
        public DbSet<NCM> NCMs { get; set; }

        public ConexaoDBS(DbContextOptions<ConexaoDBS> options) : base(options) { }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
