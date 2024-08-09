using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group29_BlitzCafe
{
    class MenuItem
    {
        //create attributes
        private readonly int itemID;
        private string descr;
        private decimal price;

        //Constructor for menu item
        public MenuItem(int itemID, string descr, decimal price)
        {
            //call setters to initialize attributes
            this.itemID = itemID;
            setDescr(descr);
            setPrice(price);
        }
      
        //set description
        public void setDescr(string descr)
        {
            this.descr = descr;
        }
        //set price
        public void setPrice(decimal price)
        {
            this.price = price;
        }
        //get decription
        public string getDescr()
        {
            return this.descr;
        }
        //get item id
        private int getItemID()
        {
            return this.itemID;
        }
        //get item price
        public decimal getPrice()
        {
            return this.price;
        }
        //override tostring method
        public string toString()
        {
            return "Item #: " + getItemID() + "\nDescription: " + getDescr() + "\nPrice:" + getPrice();
        }
    }

}

