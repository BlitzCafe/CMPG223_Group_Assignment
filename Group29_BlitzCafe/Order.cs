using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group29_BlitzCafe
{
    public class Order
    {
        //create attributes, orderID can only be set once
        private readonly int orderID;
        private DateTime orderDate;
        private bool isPayed;
        private bool loyaltyPointsUsed;

        //Create new order object
        public Order(int orderID, DateTime orderDate, bool isPayed, bool loyaltyPointsUsed)
        {
            this.orderID = orderID;
            setOrderDate(orderDate);
            setIsPayed(isPayed);
            setLoyaltyPointsUsed(loyaltyPointsUsed);
        }
        //set order date
        public void setOrderDate (DateTime orderDate)
        {
            this.orderDate = orderDate;
        }
        //set wether the order has been payed
        public void setIsPayed( bool isPayed)
        {
            this.isPayed = isPayed;
        }
        //set if loyalty points were used 
        public void setLoyaltyPointsUsed(bool loyaltyPointsUsed)
        {
            this.loyaltyPointsUsed = loyaltyPointsUsed;
        }
        //get Order ID
        public int getOrderID()
        {
            return this.orderID;
        }
        //get date ordered
        public DateTime getOrderDate()
        {
            return this.orderDate;
        }
        //get payment status
        public bool getIsPayed()
        {
            return this.isPayed;
        }
        //get if loyalty points were used
        public bool getLoyaltyPointsUsed()
        {
            return this.loyaltyPointsUsed;
        }

        //overwrite to string method
        public string toString()
        {
            return "Order ID: " + getOrderID() + "\tOrder Date: " + getOrderDate() 
                + "\tIs Payed: " + getIsPayed() + "\tLoyalty Points Used:" + getLoyaltyPointsUsed();
        }
    }
}
