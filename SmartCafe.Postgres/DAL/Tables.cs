using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DAL
{
    public interface ITablesDal
    {
        List<TableDto> GetAllTables();
        TableDto GetTable(int id);
        Task<TableDto> UpdateTable(TableDto table);
    }

    public class Tables : ITablesDal
    {
        private readonly SmartCafeContext _dbContext;
        private readonly IMapper _mapper;

        public Tables(SmartCafeContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public List<TableDto> GetAllTables()
        {
            return this._dbContext.Tables.Select(t => this._mapper.Map<TableDto>(t)).ToList().OrderBy(x => x.Tag).ToList();
        }

        public TableDto GetTable(int id)
        {
            var table = this._dbContext.Tables.FirstOrDefault(t => t.Id == id);
            if (table != null)
            {
                return this._mapper.Map<TableDto>(table);
            }

            return null;
        }

        public async Task<TableDto> UpdateTable(TableDto table)
        {
            string deletePlaceholder = Startup.StaticConfig["UpdateActionPlaceholders:Delete"];

            var existingTable = this._dbContext.Tables.FirstOrDefault(t => t.Id == table.Id);
            if (existingTable != null)
            {
                if (!string.IsNullOrEmpty(table.Tag))
                {
                    existingTable.Tag = table.Tag;
                }

                if (!string.IsNullOrEmpty(table.Description))
                {
                    if (table.Description == deletePlaceholder)
                    {
                        existingTable.Description = string.Empty;
                    }
                    else
                    {
                        existingTable.Description = table.Description;
                    }
                }

                if (table.IsInUse.HasValue)
                {
                    existingTable.IsInUse = (bool)table.IsInUse;
                }

                await this._dbContext.SaveChangesAsync();

                return table;
            }

            return null;
        }
    }
}
