using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepo
{
   public class DevTeamRepository
    {
        private List<DevTeam> _listOfTeams = new List<DevTeam>();

       
        public void AddTeamToList(DevTeam content)
        {
            _listOfTeams.Add(content);
        }

        
        public List<DevTeam> GetTeamList()
        {
            return _listOfTeams;
        }

        
        public bool UpdateExistingTeam(DevTeam existingContent, DevTeam newContent)
        {
            

            if (existingContent != null)
            {
                existingContent.TeamName = newContent.TeamName;
                existingContent.TeamNumber = newContent.TeamNumber;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public bool RemoveTeamFromList(string teamNumber)
        {
            DevTeam content = GetTeamByTeamNumber(teamNumber);

            if (content == null)
            {
                return false;
            }

            int intialCount = _listOfTeams.Count;
            _listOfTeams.Remove(content);

            if (intialCount > _listOfTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
        public DevTeam GetTeamByTeamNumber(string teamNumber)
        {
            foreach (DevTeam content in _listOfTeams)
            {
                if (content.TeamNumber == teamNumber)
                {
                    return content;
                }
            }

            return null;
        }
    }
}




