using System;
using System.Collections.Generic;
using System.Text;

namespace PersonAddressProject
{
    public class Person
    {
        private String surname;
        private String otherNames;
        private int Age;
        private Address livesAt;

        public void setSurname(String theSurname)
        {
            surname = theSurname;
        }
        public String getSurname()
        {
            return surname;
        }

        public void setOthernames(String theOthernames)
        {
            otherNames = theOthernames;
        }
        public String getotherNames()
        {
            return otherNames;
        }

        public void setAge(int theAge)
        {
            Age = theAge;
        }
        public int getAge()
        {
            return Age;
        }

        //constructor

        public Person(String aSurname, String aForename, int anAge)
        {
            surname = aSurname;
            otherNames = aForename;
            Age = anAge;

                
        }
    }
}
