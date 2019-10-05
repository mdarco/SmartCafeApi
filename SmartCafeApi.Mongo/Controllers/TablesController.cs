using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartCafeApi.Mongo.Models;
using SmartCafeApi.Mongo.Services;

namespace SmartCafeApi.Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly TableService _tableService;

        public TablesController(TableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet]
        public ActionResult<List<Table>> Get() =>
            _tableService.Get();
    }
}
