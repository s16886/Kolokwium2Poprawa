using System;
using System.Collections.Generic;

#nullable disable

namespace Kolokwium2.Models
{
    public partial class Team
    {
        public Team()
        {
            Files = new HashSet<File>();
            Memberships = new HashSet<Membership>();
        }

        public int TeamId { get; set; }
        public int OrganizationId { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
