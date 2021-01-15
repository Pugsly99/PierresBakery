using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }

    public ICollection<TreatFlavor> JoinEntries { get; }
  }
}  