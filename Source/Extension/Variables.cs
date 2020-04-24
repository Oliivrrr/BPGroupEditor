using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPGroupEditor
{
    public class Variables
    {
        public static List<Group> gr;
        public static MetroTabPage activeTab;
        public static Group activeGroup;
        public static List<string> recentMemberList = new List<string>();
        public static List<string> recentPermList = new List<string>();
        public static List<string> recentInheritList = new List<string>();
    }
}
