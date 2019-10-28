using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCafe.Postgres.DAL;
using SmartCafe.Postgres.DTO;

namespace SmartCafe.Postgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ITablesDal _dal;
        private readonly ILogger<LoginController> _logger;

        public TablesController(ITablesDal dal, ILogger<LoginController> logger)
        {
            this._dal = dal;
            this._logger = logger;
        }

        [HttpGet]
        public ActionResult<List<TableDto>> GetAllTables()
        {
            var tables = this._dal.GetAllTables();
            return Ok(tables);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<TableDto> GetTable(int id)
        {
            var table = this._dal.GetTable(id);
            return Ok(table);
        }

        [HttpPut]
        public async Task<ActionResult<TableDto>> UpdateTable(TableDto table)
        {
            var updatedTable = await this._dal.UpdateTable(table);
            if (updatedTable != null)
            {
                return Ok(updatedTable);
            }

            return NotFound();
        }
    }
}