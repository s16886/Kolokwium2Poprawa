using System;
using System.Collections.Generic;

#nullable disable

namespace Kolokwium2.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Members = new HashSet<Member>();
            Teams = new HashSet<Team>();
        }

        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDomain { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
