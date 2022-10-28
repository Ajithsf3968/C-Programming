namespace BlackTicket
{
    public class ScreeningDetails
    {
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int NoOfSeatsAvailable { get; set; }
        public double Price { get; set; }
        public ScreeningDetails(string movieID,string theatreID,int seatsAvailable,double price)
        {
           MovieID=movieID;
           TheatreID=theatreID;
           NoOfSeatsAvailable=seatsAvailable;
           Price=price;
        }
        
        
        
        
        
        
        
        
    }
}