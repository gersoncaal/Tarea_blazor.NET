using Microsoft.EntityFrameworkCore;
namespace ApiEmpressa.Models;

public class Conexiones : DbContext {
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
}