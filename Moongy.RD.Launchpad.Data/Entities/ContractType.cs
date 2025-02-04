using System.ComponentModel.DataAnnotations;

namespace Moongy.RD.Launchpad.Data.Entities;

public class ContractType
{
    [Key]
    public int Id { get; set; }

    public Guid UUid { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ContractType> ContractTypes { get; set; } = [];
}
