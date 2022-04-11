using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Models
{
    public class Account : DomainObject
    {
        public User AccountHolder { get; set; }
        public bool isProAccount { get; set; }
    }
}
