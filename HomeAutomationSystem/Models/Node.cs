using System;

namespace HomeAutomationSystem.Models
{
  public class Node
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Room { get; set; }
    public string Component { get; set; } // plug, tv, etc
    public bool Powered { get; set; }
    
  }
}
