namespace CafeteriaCardManagement
{
    public class CartItem
    {
        private static int s_itemID=100;
        public string ItemID { get;  }
        public string FoodID{ get; set; }
        public string OrderID { get; set; }
        
        
        public double OrderPrice{ get; set; }
        public int OrderQuantity { get; set; }

        public CartItem(string foodID,string orderID,double orderPrice,int orderQuantity)
        {
             s_itemID++;
             ItemID="ITID"+s_itemID;
             FoodID=foodID;
             OrderID=orderID;
             OrderPrice=orderPrice;
             OrderQuantity=orderQuantity;
        }
        
        
        
        
        
        
        
        
    }
}