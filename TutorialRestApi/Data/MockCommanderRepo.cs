using System.Collections.Generic;
using TutorialRestApi.Models;

namespace TutorialRestApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>()
            {
                new Command { Id = 0, HowTo = "Boil Egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "GEt a knife", Platform = "knife & chopping" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place a teabag", Platform = "Kettle a cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil Egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
