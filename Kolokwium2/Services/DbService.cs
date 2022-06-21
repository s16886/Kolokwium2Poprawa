
using Kolokwium2.Exceptions;
using Kolokwium2.Models;
using Kolokwium2.Models.DTO;
using Kolokwium2.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class DbService : IDbService
    {
        private readonly masterContext _dbContext;
        public DbService(masterContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddMember(SomeSortOfMember newMember)
        {
            
            _dbContext.Add(new Member { MemberName = newMember.MemberName, MemberSurname = newMember.MemberSurname});
            await _dbContext.SaveChangesAsync();
        }

        public async Task<SomeSortOfTeam> GetTeamAsync(int TeamID)
        {
            var team = await _dbContext.Teams.Where(e => e.TeamId == TeamID).FirstOrDefaultAsync();
            if(team == null) throw new TeamNotFoundException();
            return await _dbContext.Teams
                .Select(e => new SomeSortOfTeam
                {
                    TeamName = e.TeamName,
                    TeamDescription = e.TeamDescription,
                    Organization = new SomeSortOfOrganization { OrganizationName = e.Organization.OrganizationName, OrganizationDomain = e.Organization.OrganizationDomain },
                    Members = e.Memberships.Select(e => new SomeSortOfMember { MemberName = e.Member.MemberName, MemberSurname = e.Member.MemberSurname }).OrderBy(e => e.MemberName)
                }).SingleOrDefaultAsync();
        }
    }
}
