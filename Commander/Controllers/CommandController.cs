using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //sdded comment
        private readonly ICommanderRepo _repositary;
        
        public CommandsController(ICommanderRepo  repositary)
        {
            _repositary = repositary;
        }
       // private readonly MockCommanderRepo _repositary = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repositary.GetAllCommands();

            return Ok(commandItems);
        }
        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repositary.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}
