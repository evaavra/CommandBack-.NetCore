using System.Collections;
using System.Collections.Generic;
using TutorialRestApi.Models;

namespace TutorialRestApi.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);


    }
}
