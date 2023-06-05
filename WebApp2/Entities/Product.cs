using WebApp2.Entities.Base;

namespace WebApp2.Entities;

public class Product : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Count { get; set; }
}
