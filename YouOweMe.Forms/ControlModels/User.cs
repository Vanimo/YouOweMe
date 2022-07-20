using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouOweMe.Forms.ControlModels
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

        public Guid Id => m_id;

        public decimal GetBalance()
        {
            return m_currentBalance;
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
            return Convert.ToBase64String(Id.ToByteArray()).Substring(0, 8) + ": " + FullName;
        }
    }
}
