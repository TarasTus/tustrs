using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classbank
{
    class Bank
    {
        public int Account { get; private set; }
        private string fullName;
        private int age;
        private bool anyCredits;

        public Bank(int account, string fullName, int age, bool anyCredits)
        {
            Account = account;
            this.fullName = fullName;
            this.age = age;
            this.anyCredits = anyCredits;
        }
    }
}


