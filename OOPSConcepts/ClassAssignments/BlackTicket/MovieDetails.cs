namespace BlackTicket
{
    public class MovieDetails
    {
        private static int s_movieID=1000;
        public string MovieID { get;  }
        public string MovieName { get; set; }
        public string Language { get; set; }
        
        
        public MovieDetails(string movieName,string language)
        {
            s_movieID++;
            MovieID="MID"+s_movieID;
            MovieName=movieName;
            Language=language;
        }
        
        
        
    }
}