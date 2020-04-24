using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokeProtocol.API;

namespace BPGroupEditor
{
    class ExtensionMethods
    {
        public static string GroupNameTypeToInfo(GroupType grptype)
        {
            if (grptype == GroupType.AccountID)
                return "Enter the users SteamID64 or registered account name if Steam auth is disabled. Example: 76561198088598550 or NongBenz";
            if (grptype == GroupType.ConnectionIP)
                return "Enter users IPv4. Example: \"127.0.0.1\"";
            if (grptype == GroupType.JobIndex)
                return "Enter user JobID. Example: \"3\"";
            if (grptype == GroupType.JobName)
                return "Enter user job name. Example: \"Police\"";
            if (grptype == GroupType.JobGroupIndex)
                return "Enter user job group index. \"0 = Citizen(Most Jobs), 1 = Criminal(Gang Member), 2 = LawEnforcement(SpecOps, Police)\" Example: \"2\"";
            else
            {
                return "The identifier of the scriptable trigger the user is currently in. (if any) Example: \"SomeStringIdentifier\"";
            }
        }
    }
}
