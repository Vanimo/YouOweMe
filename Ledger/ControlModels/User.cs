using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.ControlModels
{
    internal class User
    {
        decimal m_currentBalance;

        string m_fullName;

        Guid m_id;

        public User(string fullname)
        {
            m_fullName = fullname;
            m_currentBalance = 0;
            m_id = Guid.NewGuid();
        }

        // TODO: Add constructor from storage type

        public string FullName => m_fullName;

        public Guid Guid => m_id;

        public decimal Balance => m_currentBalance;

        public string Id
        {
            get
            {
                return Convert.ToBase64String(Guid.ToByteArray()).Replace("=", null);
            }
        }

        public string FormattedBalance
        {
            get
            {
                return "€ " + Balance.ToString("N2");
            }
        }

        public void SubtractFromBalance(decimal amount)
        {
            m_currentBalance -= amount;
        }

        public void AddToBalance(decimal amount)
        {
            m_currentBalance += amount;
        }

        public override string ToString()
        {
            return FullName + " (" + Convert.ToBase64String(Guid.ToByteArray()).Substring(0, 8) + ")";
        }
    }
}
