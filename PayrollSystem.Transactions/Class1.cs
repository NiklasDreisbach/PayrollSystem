﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Transactions
{
    public interface ITransaction
    {
        void Execute();
    }
}
