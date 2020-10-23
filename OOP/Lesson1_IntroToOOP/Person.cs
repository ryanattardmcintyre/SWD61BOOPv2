using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_IntroToOOP
{
    //class: is a blueprint (template) that defines an entity structure. An entity (usually) represents a real-life model/
    //       object which is described using characteristics 
    //     : use Pascal casing for public members/objects
    //field: is a variable which describes something about the model/object
            //: use camel casing for field names
    //property: is (usually) declared as public and controls the accessibility to the field

    class Person //an example of a class
    {
        string idCardNo;
        private string name; //an example of a field
        string surname;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string IdCard
        {
            get { return idCardNo; }
            set
            {
                switch (value.ToString().Length)
                {
                    case 5:
                        idCardNo = "00" + value;
                        break;
                    case 6:
                        idCardNo = "0" + value;
                        break;
                    default:
                        idCardNo = value.ToString();
                        break;
                }
                idCardNo = value.ToString().ToUpper();
            } 
        }

        public string FullName //read only property
        {
            get { return Name + " " + Surname; }

        }

        public string Surname { get => surname; set => surname = value; }


        public string Address { get; set; } //taking a shortcut (if we know that we do not need any particular implementation for this particular member
        public string MobileNo { get; set; }
        public string TelNo { get; set; }

        public DateTime DateOfBirth { get; set; }


        public int CalculateAge()
        {
            return DateTime.Today.Year - DateOfBirth.Year;
        }

        public string DelimitAddress(char c)
        {
            string[] delimitedAddress =  Address.Split(new char[] { ' ' });
            string output = "";
            foreach(string s in delimitedAddress)
            {
                output += s + c + " ";
            }

            return output.Remove(output.Length-2);


        }

        



    }
}
