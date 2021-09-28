using Developer_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{

    public class DeveloperRepository
    {
        private readonly List<Developer> _developers = new List<Developer>();

        public bool AddContentToDeveloperRepo(Developer content)
        {
            _developers.Add(content);

            int startingCount = _developers.Count;
            bool wasAdded = (_developers.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //get 
        public List<Developer> GetDevelopers()
        {
            return _developers;
        }

        //get by name
        public Developer GetDeveloperByName(string theDeveloperYouAreLookingFor)
        {
            foreach (Developer content in _developers)
            {
                if (content.DeveloperName == theDeveloperYouAreLookingFor) //why need tolower
                {
                    return content;
                }
            }
            return null;
        }

        //get by id
        public Developer GetDeveloperByIDNumber(string idNumber)
        {
            foreach (Developer developer in _developers)
            {
                if (developer.IdNumber == idNumber)
                {
                    return developer;
                }
            }
            return null;
        }
        public bool UpdateExistingContent(Developer existingContent, Developer newContent)
        {
            if (existingContent != null)
            {
                existingContent.TeamName = newContent.TeamName;
                existingContent.DeveloperName = newContent.DeveloperName;
                existingContent.IdNumber = newContent.IdNumber;
                existingContent.PluralsightAccess = newContent.PluralsightAccess;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteContent(Developer existingContent)
        {
            bool result = _developers.Remove(existingContent);
            return result;
        }

        public Developer UpdateExistingContent(Developer updatedDeveloper)
        {
            throw new NotImplementedException();
        }
    }
}
