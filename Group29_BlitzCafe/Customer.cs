using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group29_BlitzCafe
{
    class Customer
    {
        private readonly int customerID;
        private string lastName, firstName;
        private string cellNo;
        private bool isLoyatyMem;
        private DateTime date_Joined;

        //Constructor
        public Customer(int customerID, string lastName, string firstName, string cellNo, bool isLoyatyMem, DateTime date_Joined)
        {
            this.customerID = customerID;
            setLastName(lastName);
            setFirstName(firstName);
            setCellNo(cellNo);
            setIsLoyaltyMem(isLoyatyMem);
            setDateJoined(date_Joined);
        }

        //Accessors

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setCellNo(string cellNo)
        {
            this.cellNo = cellNo;
        }

        public void setIsLoyaltyMem(bool isLoyatyMem)
        {
            this.isLoyatyMem = isLoyatyMem;
        }

        public void setDateJoined(DateTime date_Joined)
        {
            this.date_Joined = date_Joined;
        }

        //Mutators
        public int getCustomerID()
        {
            return customerID;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getCellNo()
        {
            return cellNo;
        }

        public bool getIsLoyaltyMem()
        {
            return isLoyatyMem;
        }

        public DateTime getDateJoined()
        {
            return date_Joined;
        }

        //ToString method
        public string toString()
        {
            return "Customer ID: " + getCustomerID() + "\tFirst Name: " + getFirstName() + "\tLast Name: " + getLastName() + "\tCellphone Number: " + getCellNo() + "\tIs Loyalty member?: " + getIsLoyaltyMem() + "\tDate Joined: " + getDateJoined();
        }
    }
}