using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipOOTask
{
    abstract class Teacher : Person
    {
        private int staffID;
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        protected ITeach TeachBehavior;
        public override string getOccupation()
        {
            return "Teacher";
        }

        public Teacher(string pFName, string pLName, string pGender, int pStaffID) : base(pFName, pLName, pGender)
        {
            staffID = pStaffID;
        }

        public override string Work()
        {
            return TeachBehavior.Teach();
        }
    }
}
