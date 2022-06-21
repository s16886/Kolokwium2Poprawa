using Kolokwium2.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public interface IDbService
    {
        Task<SomeSortOfTeam> GetTeamAsync(int TeamID);
        Task AddMember(SomeSortOfMember newMember);
    }
}
