using HomeAutomationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeAutomationSystem.Services
{
  public class NodeService
  {
    public static string PowerOnNode(IEnumerable<Node> nodeList, Guid nodeId)
    {
      string _name = string.Empty;
      string _room = string.Empty;
      bool _powered = true;

      IEnumerable<Node> query = from node in nodeList
                                where node.Id == nodeId
                                select node;

      foreach (var item in query)
      {
        _name = item.Name;
        _room = item.Room;
        _powered = item.Powered;
      }

      return $"{_name} in {_room} is now {(_powered == true ? "off" : "on")}";
    }
  }
}
