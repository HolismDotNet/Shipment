namespace Shipment;

public class Repository
{
    public static Write<Shipment.Package> Package
    {
        get
        {
            return new Write<Shipment.Package>(new ShipmentContext());
        }
    }
}
