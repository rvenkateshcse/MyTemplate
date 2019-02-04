using Microsoft.EntityFrameworkCore;

namespace WebAPITemplate
{
    internal class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }
    }
}