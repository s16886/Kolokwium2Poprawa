using System.Collections.Generic;

namespace Kolokwium2.Models.DTO
{
    public class SomeSortOfTeam
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public SomeSortOfOrganization Organization { get; set; }
        public IEnumerable<SomeSortOfMember> Members { get; set; }

    }
}
