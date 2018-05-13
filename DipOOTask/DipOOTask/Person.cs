using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipOOTask
{
    public abstract class Person
    {
        private string fname;
        private string lname;
        private string gender;

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }


        public string getGender()
        {
            return gender;
        }

        public virtual string getOccupation()
        {
            return "Unemployed";
        }

        public Person(string pFName, string pLName, string pGender)
        {
            fname = pFName;
            lname = pLName;
            gender = pGender;

            if (gender != "M" || gender != "F")
                throw new Exception("Invalid Gender passed to Person Constructor!");
        }

        public Person(string pGender)
        {
            if (pGender == "M")
            {
                fname = "John";
                lname = "Doe";
                gender = pGender;
            }
            else if (pGender == "F")
            {
                fname = "Jane";
                lname = "Doe";
                gender = pGender;

            }
            else throw new Exception("Invalid Gender passed to Person Constructor!");

        }
        public abstract string Work();

    }
}