using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y4C.Models
{
    public interface IAddAccountRepository
    {
        IEnumerable<AddContent> AC { get; }
    }
}
