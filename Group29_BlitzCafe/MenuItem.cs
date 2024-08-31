using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group29_BlitzCafe
{
    public class MenuItem : IComparable<MenuItem>
    {
        //create attributes
        private readonly int itemID;
        private string descr;
        private decimal price;
        private int qtySold;

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

        public void setQtySold(int qtySold)
        {
            this.qtySold = qtySold;
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
        public int getItemID()
        {
            return this.itemID;
        }
        //get item price
        public decimal getPrice()
        {
            return this.price;
        }

        public int getQtySold()
        {
            return this.qtySold;
        }

        //comparable method to compare by price
        public int CompareTo(MenuItem other)
        {
            if (other == null) return 1;
            return this.price.CompareTo(other.getPrice());
        }

        //check if other object is the same as the current one
        public bool equals(MenuItem other)
        {
            if (other == null) return false;
            return this.itemID == other.itemID &&
                   this.descr == other.descr &&
                   this.price == other.price;
        }

        //override tostring method
        public string toString()
        {
            return "Item #: " + getItemID() + "\nDescription: " + getDescr() + "\nPrice:" + getPrice();
        }
    }

}

