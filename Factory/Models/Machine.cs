using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string MachineType { get; set; }
    public string MachineName { get; set; }
    public DateTime BirthDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}