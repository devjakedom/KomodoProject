using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{
    public class Developer
    {
        public Developer() { }
        public Developer(string developerName, string idNumber, string teamName, bool pluralsightAccess)
        {
            DeveloperName = developerName;
            IdNumber = idNumber;
            TeamName = teamName;
            PluralsightAccess = pluralsightAccess;
        }

        public string DeveloperName { get; set; }

        public string IdNumber { get; set; }

        public string TeamName { get; set; }

        public bool PluralsightAccess { get; set; }
           
        }
            
    }

