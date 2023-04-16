using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal abstract class APerson
    {
        private int personID;
        private static int idCounter = 1;
        private string name;
        private string contactNo;
        private string address;

        public int PersonID { get => personID; set => personID = value; }
        public string Name { get => name; set => name = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Address { get => address; set => address = value; }
        

        public APerson()
        {
            PersonID = idCounter;
            idCounter++;
        }
        public APerson(string name) : this()
        {
            Name = name;
        }

        public APerson(string name,  string contactNo) : this(name)
        {
            Name = name;
            ContactNo = contactNo;
        }
        public APerson(string name, string contactNo, string address) : this(name, contactNo)
        {
            Name = name;
            ContactNo = contactNo;
            Address = address;
        }
    }
}
