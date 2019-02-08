using System;
using System.Collections.Generic;
using System.Text;

namespace PersonAddressProject
{
    public class Address
    {
        private int theHouseNumber;
        private String theStreetName;
        private String theCityName;
        private String thePostCode;

        public void setHouseNumber(int HouseNumber)
        {
            HouseNumber = theHouseNumber;
        }
        public void setStreetName(String StreetName)
        {
            StreetName = theStreetName;
        }
        public void setCityName(String CityName)
        {
            CityName = theCityName;
        }
        public void setPostCode(String PostCode)
        {
            PostCode = thePostCode;
        }

        //construct

        public Address(int num, string strt, string city, string pst)
        {
            num = theHouseNumber;
            strt = theStreetName;
            city = theCityName;
            pst = thePostCode;
        }
    }
}
