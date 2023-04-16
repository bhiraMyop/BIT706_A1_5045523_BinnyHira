using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class BankStaff : APerson
    { 

       //Getter and Setters
        // Constructors
        public BankStaff(string name, string contactNo, string address) : base(name, contactNo, address)
        {
           // Default constructor for Banks staff only.
        }

        public override string ToString()
        {
            return ($"{PersonID.ToString()}  {Name.ToString()} {ContactNo.ToString()} {Address.ToString()} ");
        }


    }
}
