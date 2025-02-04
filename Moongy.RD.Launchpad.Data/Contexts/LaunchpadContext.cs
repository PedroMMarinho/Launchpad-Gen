using Microsoft.EntityFrameworkCore;
using Moongy.RD.Launchpad.Data.Entities;

namespace Moongy.RD.Launchpad.Data.Contexts;

public class LaunchpadContext : DbContext
{
    public DbSet<ContractType> ContractTypes { get; set; }
}
