using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound05.Banco;

internal class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; }

    private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound05;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}