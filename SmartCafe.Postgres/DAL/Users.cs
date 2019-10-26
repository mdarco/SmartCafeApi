using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace SmartCafe.Postgres.DAL
{
    public class Users
    {
        private readonly SmartCafeContext _dbContext;
        private readonly IMapper _mapper;

        public Users(SmartCafeContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public async Task<UserDto> GetUser(string username)
        {
            var user = this._dbContext.Users.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            if (user != null)
            {
                var userDto = this._mapper.Map<UserDto>(user);

                // get user groups
                await this._dbContext.Entry(user).Collection(c => c.UserGroupMembers).LoadAsync();

                userDto.UserGroups = new List<string>();
                foreach (var group in user.UserGroupMembers)
                {
                    await this._dbContext.Entry(group).Reference(r => r.UserGroup).LoadAsync();

                    userDto.UserGroups.Add(group.UserGroup.Name);
                }

                return userDto;
            }

            return null;
        }
    }
}
