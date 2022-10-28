namespace BlackTicket
{
    public class TheatreDetails
    {
        private static int s_theatreID=300;
        public string TheatreID { get;  }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }
        
        public TheatreDetails(string theatreName,string theatreLocation)
        {
           s_theatreID++;
            TheatreID="TID"+s_theatreID;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }
        
        
        
        
    }
}