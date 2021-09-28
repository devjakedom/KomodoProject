
using Developer_Repository;
using DevTeamRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Console
{
    class ProgramUI
    {
        private DeveloperRepository _devContent = new DeveloperRepository();
        private DevTeamRepository _devTeamContent= new DevTeamRepository();


        public void run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.Clear();
                Console.WriteLine
                  ("Sup people. welcome to the thunder dome AKA komodo insurance\n" +
                    "Please select a menu option:\n" +
                    " \n" +
                    "1. Create New Dev\n" +
                    "2. View All Devs\n" +
                    "3. View Dev By ID Number\n" +
                    "4. Update Dev Info\n" +
                    "5. Delete Dev\n" +
                    "6. Devs without pluralsight\n" +
                    "7. Create dev team and add devs\n" +
                    "8. Teams\n" +
                    "9. Dev Team By ID\n" +
                    "10. Remove Dev Team\n" +
                    "11. Exit");

                //Get user input
                string input = Console.ReadLine();

                //Evaluate user input
                switch (input)
                {
                    case "1":
                        CreateNewDeveloper();
                        break;

                    case "2":
                        ViewAllDevelopers();
                        break;

                    case "3":
                        ViewDeveloperByIdNumber();
                        break;

                    case "4":
                        UpdateExistingDeveloperInfo();
                        break;

                    case "5":
                        DeleteExistingDeveloper();
                        break;

                    case "6":
                        ViewDevelopersWithoutPluralsight();
                        break;

                    case "7":
                        CreateNewDevTeam();
                        break;

                    case "8":
                        ViewAllTeams();
                        break;

                    case "9":
                        ViewTeamByTeamIDNumber();
                        break;

                    case "10":
                        RemoveDeveloperTeam();
                        break;

                    case "11":
                        Console.WriteLine("Dueces");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Hello. My name is Inigo Montoya. You killed my father. Prepare to die.");
                        break;
                }

                Console.WriteLine("DO YOU ACTUALLY WANT TO KEEP GOING?  \n +" +
                    "IF YOU DO ANY KEY WORKS \n +" +
                    "OTHERWISE THE _X_ AT THE TOP RIGHT OF WINDOW WILL LET ME GO AND REST");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewDeveloper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();
            //name
            Console.WriteLine("Enter the developer's name:");
            newDeveloper.DeveloperName = Console.ReadLine();
           
            //idnumber
            Console.WriteLine("Enter the developer's ID number:");
            newDeveloper.IdNumber = Console.ReadLine();
            //pluralsight
            Console.WriteLine("Does the developer have access to Pluralsight? (Enter yes or no)");
            string pluralsightAccessString = Console.ReadLine().ToLower();


            if (pluralsightAccessString == "yes")
            {
                newDeveloper.PluralsightAccess = true;
            }
            else
            {
                newDeveloper.PluralsightAccess = false;
            }


            _devContent.AddContentToDeveloperRepo(newDeveloper);
        }

        private void ViewAllDevelopers()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _devContent.GetDevelopers();

            foreach (Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"Full Name: {developer.DeveloperName}\n" +
                    $"ID Number: {developer.IdNumber}\n" +
                    $"Pluralsight Access: {developer.PluralsightAccess}\n" +
                    $" ");
            }

        }
        private void ViewDeveloperByIdNumber()
        {
            Console.Clear();
            Console.WriteLine("Enter the dev ID number:");

            string idNumber = Console.ReadLine();

            Developer developer = _devContent.GetDeveloperByIDNumber(idNumber);

            if (developer != null)
            {
                Console.WriteLine($"Name: {developer.DeveloperName}\n" +
                    $"ID Number: {developer.IdNumber}\n" +
                    $"Team: {developer.TeamName}\n" +
                    $"Pluralsight Access: {developer.PluralsightAccess}\n" +
                    $" ");
            }
            else
            {
                Console.WriteLine("Umm, that is not an ID I recognize my guy.");
            }

        }
        private void UpdateExistingDeveloperInfo()
        {
            Console.Clear();

            Console.WriteLine("Enter the developer ID Number:");

            string existingContent = Console.ReadLine();

            Developer newContent = _devContent.GetDeveloperByIDNumber(existingContent);

            if(newContent == null)
            {
                Console.WriteLine("WRONG!!!!!!!! TRY AGAIN!!!");
                PressAnyKeyToContinue();
                return;
            }

            //name
            Console.WriteLine("Enter the dev name:");
            newContent.DeveloperName = Console.ReadLine();
            //idnumber
            Console.WriteLine("Enter the dev ID number:");
            newContent.IdNumber = Console.ReadLine();
            //pluralsight
            Console.WriteLine("Does pluralsight access developer have?? (Enter yes or no)");
            string pluralsightAccessString = Console.ReadLine().ToLower();

            
        }

        private void DeleteExistingDeveloper()
        {
            

        }

        private void ViewDevelopersWithoutPluralsight()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _devContent.GetDevelopers();

            foreach (Developer developer in listOfDevelopers)
            {
                if (developer.PluralsightAccess == false)
                {
                    Console.WriteLine($"Name: {developer.DeveloperName}\n" +
                        $"ID Number: {developer.IdNumber}\n" +
                        $" ");
                }
                else
                {

                }
            }
        }
        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue... Count Rugen");
            Console.ReadKey();
        }
        //devteam
        private void CreateNewDevTeam()
        {
            Console.Clear();
            DevTeam newDevTeam = new DevTeam();

            Console.WriteLine("Enter the dev team name:");
            newDevTeam.TeamName = Console.ReadLine();

            Console.WriteLine("Enter the team ID:");
            newDevTeam.TeamNumber = Console.ReadLine();

            Console.WriteLine( "WHATS THE HUMAN'S NAME? ");
            newDevTeam.TeamMember = Console.ReadLine();

            _devTeamContent.AddTeamToList(newDevTeam);
        }

        private void ViewAllTeams()
        {
            Console.Clear();

            List<DevTeam> listOfDevTeams = _devTeamContent.GetTeamList();
           

            foreach (DevTeam devTeam in listOfDevTeams)
            {
                Console.WriteLine($"\n" +
                $"Team Name: {devTeam.TeamName}\n" +
                $"Human: {devTeam.TeamMember}\n" +
                $"Team ID Number: {devTeam.TeamNumber}");
            }
        }
        private void ViewTeamByTeamIDNumber()
        {
            Console.Clear();
            Console.WriteLine("Enter the Team ID number:");

            string teamIdNumber = Console.ReadLine();

            DevTeam devTeam = _devTeamContent.GetTeamByTeamNumber(teamIdNumber);

            if (devTeam != null)
            {
                Console.WriteLine($"\n" +
                    $"Team Name: {devTeam.TeamName}\n" +
                    $"Human: {devTeam.TeamMember}\n" +
                   $"Team ID Number: {devTeam.TeamNumber}");
                
                
            }
            else
            {
                Console.WriteLine("But it's so simple. All I have to do is divine it from what I know of you. Are you the sort of man who would put the poison into his own goblet or his enemies? Now, a clever man would put the poison into his own goblet because he would know that only a great fool would reach for what he was given. I am not a great fool so I can clearly not choose the wine in front of you...But you must have known I was not a great fool; you would have counted on it, so I can clearly not choose the wine in front of me. ");
            }
        }

        private void RemoveDeveloperTeam()
        {
            ViewAllTeams();
            Console.WriteLine("Enter the ID number of the team you would like to poison...I mean DELETE:");
            string input = Console.ReadLine();

            bool wasRemoved = _devTeamContent.RemoveTeamFromList(input);

            if (wasRemoved)
            {
                Console.WriteLine("The team has been poisoned...I mean DELETED, SORRY.");
            }
            else
            {
                Console.WriteLine("The team cannot be poisoned...DELETED. Because its not a real team idiot.");
            }

        }
    }
}
