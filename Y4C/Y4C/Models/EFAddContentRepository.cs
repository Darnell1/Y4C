﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y4C.Models
{
    public class EFAddContentRepository : IAddAccountRepository
    {
        private AddContentDBContext context;
        public EFAddContentRepository(AddContentDBContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<AddContent> AC => context.AC;
    }
}
