using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card
{
    public class CreditCard
    {
        int rahunok;
        int No;
        int CWW;
        string name;
        public CreditCard(int rah, int no, int cww, string name)
        {
            this.rahunok = rah;
            this.No = no;
            this.CWW = cww;
            this.name = name;
        }
        public CreditCard() { rahunok = 0; No = 0; CWW = 0; name = "no name"; }
        int GetSetRah
        {
            get { return rahunok; }
            set { rahunok = value; }
        }
        int GetSetNo
        {
            get { return No; }
            set { No = value; }
        }
        int GetSetCWW
        {
            get { return CWW; }
            set { CWW = value; }
        }
        string GetSetName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
