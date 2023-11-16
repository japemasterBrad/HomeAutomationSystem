using HomeAutomationSystem.Models;
using HomeAutomationSystem.Services;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;

namespace HomeAutomationSystem
{
  public partial class HomeAutomationSystem : Form
  {
    NodeService nodeService = new NodeService();
    public HomeAutomationSystem()
    {
      InitializeComponent();
    }

    private void bigLightLivingRoom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("3f0b70b6-9482-4961-9ddd-05aa9a731f55");
      TogglePower(nodeId);
    }

    private void stripLightsLivingRoom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("8f978c58-2ea5-4de5-9d2d-6242049a5a71");
      TogglePower(nodeId);
    }
    
    private void speakersLivingRoom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("16d76e47-0c24-4f1c-a99c-b2c28ed98c5f");
      TogglePower(nodeId);
    }

    private void tvLivingRoom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("d2813c04-4499-49fb-a552-3ba04be20b7e");
      TogglePower(nodeId);
    }

    private void plugsLivingRoom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("7924ae90-7317-4d13-b11b-73d2575a6511");
      TogglePower(nodeId);
    }

    private void plugsKitchen_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("3864359f-b035-4869-9811-305045174471");
      TogglePower(nodeId);
    }

    private void underCounterKitchen_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("981155e8-514d-4f9c-9ea8-6811a15b5600");
      TogglePower(nodeId);
    }

    private void speakersKitchen_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("d4596077-8d80-4ed0-8ea0-0dfb70be5c9a");
      TogglePower(nodeId);
    }

    private void floorLightsKitchen_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("35bc0380-68bc-49ce-baa8-edebe61c10ad");
      TogglePower(nodeId);
    }

    private void bigLightBedroom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("610de04f-a5f6-4ae4-9c85-56cc2c83f021");
      TogglePower(nodeId);
    }

    private void stripLightsBedroom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("f085f313-bf21-4e3e-b8c3-1773f9a1baad");
      TogglePower(nodeId);
    }

    private void speakersBedroom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("0e753029-34f5-4bbe-ae91-899a28ccd297");
      TogglePower(nodeId);
    }

    private void tvBedroom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("95248eb6-775c-4c26-9b04-b6048f511a6a");
      TogglePower(nodeId);
    }

    private void plugsBedroom_Click(object sender, EventArgs e)
    {
      Guid nodeId = new Guid("fb90311e-1680-45d1-82f4-c881f113d095");
      TogglePower(nodeId);
    }

    public void TogglePower(Guid id)
    {
      string resultMessage = string.Empty;
      Guid nodeId = id;
      ToggleSinglePowerInDatabase(nodeId);
      resultMessage = NodeClient.PowerOnNode(_nodeList, nodeId);
      outputConsole.Text = resultMessage;
    }
    
    public void ToggleSinglePowerInDatabase(Guid id)
    {
      if (_nodeList.Where(x => x.Id == id).FirstOrDefault().Powered == true)
        _nodeList.Where(x => x.Id == id).FirstOrDefault().Powered = false;
      else
        _nodeList.Where(x => x.Id == id).FirstOrDefault().Powered = true;
    }

    public void ToggleMultiplePowerInDatabase(string component)
    {
      _nodeList.Where(x => x.Component == component).ToList().ForEach(cc => cc.Component = component);
    }

    private List<Node> _nodeList = new List<Node>() // For development, this will move to a database
    {
      new Node()
      {
        Id = new Guid("3f0b70b6-9482-4961-9ddd-05aa9a731f55"),
        Name = "Big Light",
        Room = "Living Room",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("8f978c58-2ea5-4de5-9d2d-6242049a5a71"),
        Name = "Strip Light",
        Room = "Living Room",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("16d76e47-0c24-4f1c-a99c-b2c28ed98c5f"),
        Name = "Speaker",
        Room = "Living Room",
        Component = "Speaker",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("d2813c04-4499-49fb-a552-3ba04be20b7e"),
        Name = "TV",
        Room = "Living Room",
        Component = "TV",
        Powered = false
      },

      new Node()
      {
        Id = new Guid("3864359f-b035-4869-9811-305045174471"),
        Name = "Plugs",
        Room = "Kitchen",
        Component = "Plug",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("981155e8-514d-4f9c-9ea8-6811a15b5600"),
        Name = "Under Counter Lights",
        Room = "Kitchen",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("d4596077-8d80-4ed0-8ea0-0dfb70be5c9a"),
        Name = "Speaker",
        Room = "Kitchen",
        Component = "Speaker",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("35bc0380-68bc-49ce-baa8-edebe61c10ad"),
        Name = "Floor Light",
        Room = "Kitchen",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("610de04f-a5f6-4ae4-9c85-56cc2c83f021"),
        Name = "Big Light",
        Room = "Bedroom",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("f085f313-bf21-4e3e-b8c3-1773f9a1baad"),
        Name = "Strip Light",
        Room = "Bedroom",
        Component = "Light",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("0e753029-34f5-4bbe-ae91-899a28ccd297"),
        Name = "Speaker",
        Room = "Bedroom",
        Component = "Speaker",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("95248eb6-775c-4c26-9b04-b6048f511a6a"),
        Name = "TV",
        Room = "Bedroom",
        Component = "TV",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("fb90311e-1680-45d1-82f4-c881f113d095"),
        Name = "Plugs",
        Room = "Bedroom",
        Component = "Plug",
        Powered = false
      },
      new Node()
      {
        Id = new Guid("7924ae90-7317-4d13-b11b-73d2575a6511"),
        Name = "Plugs",
        Room = "Living Room",
        Component = "Plug",
        Powered = false
      }
    };
  }
}
