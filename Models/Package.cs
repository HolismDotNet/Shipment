namespace Shipment;

public class Package : IEntity
{
    public Package()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Identifier { get; set; }

    public long StateId { get; set; }

    public dynamic RelatedItems { get; set; }
}
