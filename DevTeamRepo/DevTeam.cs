using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepo
{
    public class DevTeam
    {
        public DevTeam() { }

        public DevTeam(string teamMember, string teamName, string teamNumber)
        {
            TeamMember = teamMember;
            TeamName = teamName;
            TeamNumber = teamNumber;
        }

        public string TeamMember { get; set; }
        public string TeamName { get; set; }
        public string TeamNumber { get; set; }
    }
}
