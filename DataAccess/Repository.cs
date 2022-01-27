namespace Shipment;

public class Repository
{
    public static Repository<Shipment.Package> Package
    {
        get
        {
            return new Repository<Shipment.Package>(new ShipmentContext());
        }
    }
}
