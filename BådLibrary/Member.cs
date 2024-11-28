using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BådLibrary
{
    public class Member : Person
    {
        public string MembershipType { get; set; }

        public Member(string name, string address, string email, string membershipType) : base(name, address, email)
        {
            membershipType = MembershipType;
        }
    }
}
