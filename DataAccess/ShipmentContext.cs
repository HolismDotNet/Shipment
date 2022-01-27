namespace Shipment;

public class ShipmentContext : DatabaseContext
{
    public override string ConnectionStringName => "Shipment";

    public DbSet<Shipment.Package> Packages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
