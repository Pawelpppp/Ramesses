using System;
using System.Collections.Generic;
using System.Text;

namespace Ramzes.Models
{
    public class Node
    {
        public int PathValue { get; set; }
        public int MeValue { get; set; }
        public Node Parent { get; private set; }
        public Node ChildA { get;  set; }
        public Node ChildB { get;  set; }
        public Node ChildC { get;  set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"I am { MeValue } ");
            return base.ToString();
        }
    }
}
