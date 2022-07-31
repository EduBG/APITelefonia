namespace APITelefonia.Controllers
{
    using APITelefonia.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private TelefoniaContext _telefoniaContext;

        public TerminalController(TelefoniaContext telefoniaContext)
        {
            _telefoniaContext = telefoniaContext;
        }

        // GET: api/<TerminalController>
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        [HttpGet]
        public IEnumerable<ResultDTO> Get()
        {
            return new Terminal().GetTerminal();
        }

        // GET api/<TerminalController>/5
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "id" })]
        [HttpGet("{id}")]
        public ResultDTO Get(int id)
        {
            return new Terminal().GetTerminal(id);
        }
    }
}