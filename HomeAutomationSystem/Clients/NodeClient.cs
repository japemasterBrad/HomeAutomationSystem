using HomeAutomationSystem.Models;
using HomeAutomationSystem.Services;
using System;
using System.Collections.Generic;

namespace HomeAutomationSystem
{
  public class NodeClient
  {
    public static string PowerOnNode(IEnumerable<Node> nodeList, Guid lightId)
    {
      string result = NodeService.PowerOnNode(nodeList, lightId);
      return result;
    }

    List<Node> _nodeList;
  }
}