using System;
using System.Collections.Generic;

#nullable disable

namespace Kolokwium2.Models
{
    public partial class Member
    {
        public Member()
        {
            Memberships = new HashSet<Membership>();
        }

        public int MemberId { get; set; }
        public int OrganizationId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
