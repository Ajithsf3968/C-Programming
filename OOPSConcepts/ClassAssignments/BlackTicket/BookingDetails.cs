namespace BlackTicket
{
    public enum Status{Booked,Cancelled}
    public class BookingDetails
    {
        private static int _bookingID=7001;
        public string BookingID{ get;  }
        
        
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public Status BookingStatus { get; set; }
        
        

        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalAmount,Status bookingStatus)
        {
            _bookingID++;
            BookingID="BID"+_bookingID;
            UserID=userID;
            MovieID=movieID;
            TheatreID=theatreID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;


        }

        
        
        
        
        
        
        
        
        
        
    }
}