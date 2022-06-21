using System;
using System.Collections.Generic;

#nullable disable

namespace Kolokwium2.Models
{
    public partial class Membership
    {
        public int MemberId { get; set; }
        public int TeamId { get; set; }
        public DateTime MembershipDate { get; set; }

        public virtual Member Member { get; set; }
        public virtual Team Team { get; set; }
    }
}
