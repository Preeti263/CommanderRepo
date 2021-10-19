using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
       // private CommanderContext context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;// = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            var re = _context.Commands.ToList();
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
