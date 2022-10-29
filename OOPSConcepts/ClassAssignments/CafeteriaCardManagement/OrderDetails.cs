using System;
namespace CafeteriaCardManagement
{
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=1000;
        public string OrderID { get;  }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public OrderDetails(string userID,DateTime orderDate,double totalPrice )
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;

        } 
        
    }
}