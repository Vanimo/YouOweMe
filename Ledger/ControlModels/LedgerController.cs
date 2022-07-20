using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.ControlModels
{
    internal class LedgerController
    {
        private Users m_users = new Users();

        private static Random m_r = new Random();

        public User AddUser(string fullName)
        {
            return m_users.AddUser(fullName);
        }

        public User AddRandomUser()
        {
            return AddUser(GenerateName(m_r.Next(5, 15)));
        }

        public static string GenerateName(int len)
        {
            var sb = new StringBuilder();

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };

            // Decide if we start with a consonant or vowel

            if (m_r.Next(2) == 0)
            {
                sb.Append(consonants[m_r.Next(consonants.Length)].ToUpper());
                sb.Append(vowels[m_r.Next(vowels.Length)]);
            }
            else
            {
                sb.Append(vowels[m_r.Next(vowels.Length)].ToUpper());
            }

            while (sb.Length < len)
            {
                sb.Append(consonants[m_r.Next(consonants.Length)]);
                if (m_r.Next(2) == 1)
                {
                    // Double consonant
                    sb.Append(consonants[m_r.Next(consonants.Length)]);
                }

                var vowel = m_r.NextDouble();
                if (vowel > 0.8)
                {
                    var v = vowels[m_r.Next(vowels.Length)];

                    sb.Append(v).Append(v);
                }
                else if (vowel > 0.5)
                {
                    sb.Append(vowels[m_r.Next(vowels.Length)]);
                    sb.Append(vowels[m_r.Next(vowels.Length)]);
                }
                else
                {
                    sb.Append(vowels[m_r.Next(vowels.Length)]);
                }
            }

            return sb.ToString();
        }
    }
}
