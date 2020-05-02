using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPGroupEditor
{
    public class Group
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public List<string> Permissions { get; set; }
        public CustomData CustomData { get; set; }
        public List<string> Members { get; set; }
        public List<string> Inherits { get; set; }
    }

    public partial class CustomData
    {
        public Data Data { get; set; }
    }
    public partial class Data
    {
    }
}
