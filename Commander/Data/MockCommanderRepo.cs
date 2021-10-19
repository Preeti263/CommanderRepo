using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
              new Command{Id=0,HowTo="boil an egg",Line="boil a water",Plateform="Kettle & Pan"},
              new Command{Id=1,HowTo="cut a bread",Line="Get a Knife",Plateform="Knife & Pan"},
              new Command{Id=2,HowTo="Make a Cup of TEA",Line="Place a Tea bag in Water",Plateform="Kettle & Cup"}
            };
            return commands;
        }
        public Command GetCommandById(int id)
        {
            var commands = GetAppCommands();
            Command cmd =new Command();
            foreach(Command c in commands)
            {
                if(c.Id==id)
                {
                    return c;
                    
                }
               
            }
            return cmd;
           
           // return commands.Where(x => x.Id == id).FirstOrDefault();

          


        }


    }
}

