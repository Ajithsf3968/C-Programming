using System;
namespace OnlineMedicalStore;

    public enum Status{Puchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=2000;
        public string OrderID { get;  }
        public string UserID { get; set; }
        public string MedicineID { get; set; }

        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        
        public DateTime OrderDate { get; set; }
        public Status OrderStatus { get; set; }
    
    public OrderDetails(string userId,string medicineId,int medicineCount,double totalPrice,DateTime orderDate,Status orderStatus)
    {
        s_orderID++;
        OrderID="OID"+s_orderID;
        UserID=userId;
        MedicineID=medicineId;
        MedicineCount=medicineCount;
        TotalPrice=totalPrice;
        OrderDate=orderDate;
        OrderStatus=orderStatus;

    }
        
}
