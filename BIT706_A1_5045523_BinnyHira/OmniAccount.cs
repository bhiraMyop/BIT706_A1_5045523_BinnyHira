using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class OmniAccount : AAccounts
    {
        // Constructors
        public OmniAccount(double interestRate) : base(interestRate)
        {
            //intreset rate is set at account creation
            //Failed fee is standard $10.00
            Overdraft = (int)OverdraftAllowed.Yes;
        }


        // Methods
        public override string deposit()
        {
            return "";
        }

        public override string withdrawl()
        {
            return "";
        }
        public override string ToString()
        {
            return ($"Account Type = Omni Account " +
                $"\nAccountNo =  {AccountNo.ToString()} " +
                $"\nBalance = ${Balance.ToString()} " +
                $"\nFailedFee = {FailedFee.ToString()} " +
                $"\nInterestRate = {InterestRate.ToString()} " +
                $"\nOverdraft Allowed = {Overdraft.ToString()} ");
        }

    }
}
