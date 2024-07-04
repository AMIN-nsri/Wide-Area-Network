using System;
namespace Final_Project_Graph
{
	
        public class Node
        {
            public string Identifier { get; set; }
            public bool IsGateway { get; set; }
            public List<Node> Neighbors { get; set; }

            public Node(string identifier, bool isGateway = false)
            {
                Identifier = identifier;
                IsGateway = isGateway;
                Neighbors = new List<Node>();
            }
        }

        public class Area
        {
            public string Identifier { get; set; }
            public bool IsSafe { get; set; }
            public List<Node> Nodes { get; set; }
            public Node Gateway { get; set; }

            public Area(string identifier, bool isSafe)
            {
                Identifier = identifier;
                IsSafe = isSafe;
                Nodes = new List<Node>();
            }
        }

        public class WAN
        {
            public List<Area> Areas { get; set; }

            public WAN()
            {
                Areas = new List<Area>();
            }

            public void AddArea(Area area)
            {
                Areas.Add(area);
            }

            public void RouteMessage(string sourceAreaId, string destinationAreaId, string message)
            {
                // Implement routing logic here
            }
        }
}

