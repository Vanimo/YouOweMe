using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.ControlModels
{
    internal interface ITransaction
    {
        void ExecuteOnUsers();
    }
}
