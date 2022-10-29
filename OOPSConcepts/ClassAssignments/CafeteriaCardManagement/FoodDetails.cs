namespace CafeteriaCardManagement
{
    public class FoodDetails
    {
        private static int s_foodID=100;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity{ get; set; }

        public FoodDetails(string foodName,double foodPrice,int quantity)
        {
           s_foodID++;
           FoodID="FID"+s_foodID;
           FoodName=foodName;
           FoodPrice=foodPrice;
           AvailableQuantity=quantity;
        }
        
    }
}