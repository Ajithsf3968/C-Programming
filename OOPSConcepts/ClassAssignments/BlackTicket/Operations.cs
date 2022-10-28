using System;
using System.Collections.Generic;
namespace BlackTicket
{
    public static class Operations
    {
        public static List<UserDetails>userList = new List<UserDetails>();
         public static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        public static List<MovieDetails>movieList=new List<MovieDetails>();
        public static List<ScreeningDetails>screenList=new List<ScreeningDetails>();
        public static List<BookingDetails>bookList=new List<BookingDetails>();
        //Main menu method called
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("-----Main Menu-----");
                System.Console.WriteLine("Enter  your option \n 1.Registration \n 2. Login \n 3. Exit");
                int option=int.Parse(Console.ReadLine());
                //getting user option
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                          Login();
                          break;
                    }
                    case 3:
                    {
                         choice="no";
                         break;
                    }
                }

            }while(choice=="yes");
        }
        //Registration method called
        public static void Registration()
        {
            //getting user details
           System.Console.WriteLine("Enter  your Name:");
           string name=Console.ReadLine();
           System.Console.WriteLine("Enter your age:");
           int age=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your mobile number:");
           long mobile=long.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter Wallet balance");
           double walletBalance=double.Parse(Console.ReadLine());
           //Adding user details in user detail object
           UserDetails user=new UserDetails(name,age,mobile,walletBalance);
           userList.Add(user);
           System.Console.WriteLine("Registration succesfull Your Registration ID:"+user.UserID);
        }
        public static void Login()
        {
            int temp=0;
             System.Console.WriteLine("----Login portal----");
             System.Console.WriteLine("Enter your user ID");
             string UserID=Console.ReadLine();
             UserDetails tempUser;
             foreach(UserDetails user in userList)
             {
                //finding user id by traversing userlist
                if(UserID==user.UserID)
                {
                  temp=1;   
                  tempUser=user;
                  SubMenu(tempUser);
                  break;
                }
             }
             if(temp==0)
             {
                 System.Console.WriteLine("Invalid user Id");
             }


        }
        //submenu called
        public static void SubMenu(UserDetails tempUser)
        {
            System.Console.WriteLine("----Sub Menu----");
            string subMenuChoice="yes";
            do
            {
                System.Console.WriteLine("Enter your choice \n 1. Ticket booking \n 2.Cancel Ticket \n 3.Booking history \n 4.Wallet Recharge \n 5.Exit");
                int menuOption=int.Parse(Console.ReadLine());
                switch(menuOption)
                {
                    case 1:
                    {
                        TicketBooking(tempUser);
                        break;
                    }
                    case 2:
                    {
                        CancelTicket(tempUser);
                        break;
                    }
                    case 3:
                    {
                        BookingHistory(tempUser);
                        break;
                    }
                }
                
            } while (subMenuChoice=="yes");

        }
        public static void TicketBooking(UserDetails tempUser)
        {
            System.Console.WriteLine("| Theatre ID | Theatre Name | Theater Location |");
            System.Console.WriteLine("----------------------------");
            foreach(TheatreDetails tempTheater in theatreList)
            {

                System.Console.WriteLine($"{tempTheater.TheatreID} | {tempTheater.TheatreName} | {tempTheater.TheatreLocation}");
                System.Console.WriteLine("----------------------------");
                
            }
             System.Console.WriteLine("Enter Theater ID");
            string theaterID=Console.ReadLine();
            int temp=0;
            foreach(TheatreDetails tempTheater in theatreList)
            {
               
                if(theaterID==tempTheater.TheatreID)
                {
                    temp=1;
                    foreach(ScreeningDetails  tempScreen in screenList)
                    {
                        if(tempScreen.TheatreID==theaterID)
                        {
                            foreach(MovieDetails tempMovie in movieList)
                            {
                                if(tempMovie.MovieID==tempScreen.MovieID)
                                {
                                    System.Console.WriteLine("| Movie ID | movie Name | movie Language ");
                                    System.Console.WriteLine($"{tempMovie.MovieID} | {tempMovie.MovieName} | {tempMovie.Language}");
                                    
                                }
                                
                            }
                        }

                    }
                }
                if(temp==0)
                {
                    System.Console.WriteLine("Enter invalid  id");
                }

            }
            System.Console.WriteLine("Enter the movie ID");
            string movieID=Console.ReadLine();
            System.Console.WriteLine("Enter the number of seats do you want to book");
            int seatCount=int.Parse(Console.ReadLine());
          
            
             foreach(ScreeningDetails screen in screenList)
            {
                if(movieID==screen.MovieID)
                {
                   
                    System.Console.WriteLine();
                     if(seatCount<=screen.NoOfSeatsAvailable)
                     {
                         double ticketPrice=(seatCount*screen.Price);
                        double totalAmount=ticketPrice+((18/ticketPrice)*100);
                        if(totalAmount<=tempUser.WalletBalance)
                        {
                             tempUser.DetectBalance(totalAmount);
                             screen.NoOfSeatsAvailable-=seatCount;
                             BookingDetails newbooking=new BookingDetails(tempUser.UserID,screen.MovieID,screen.TheatreID,screen.NoOfSeatsAvailable,totalAmount,Status.Booked);
                             bookList.Add(newbooking);
                             System.Console.WriteLine("Booking successfull");
                             break;
                             
                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient balance");
                            tempUser.RechargeWallet();
                        }

                     }
                     
                
                }
                
                
            }
           

           

        }
        //cancel ticket method called 
        public static void CancelTicket(UserDetails tempUser)
        {
            
            System.Console.WriteLine("Enter Booking Id you want to cancel");
            string bookingID=Console.ReadLine();
            foreach(BookingDetails booking in bookList)
            {
        
            if(bookingID==booking.UserID && booking.BookingStatus==Status.Booked)
            {
                System.Console.WriteLine($"{booking.BookingID} | {booking.MovieID} | {booking.TheatreID} | {booking.SeatCount } | {booking.TotalAmount} | {booking.BookingStatus}");
                foreach(ScreeningDetails screen in screenList)
                {
                    if(screen.TheatreID==booking.TheatreID && screen.MovieID==booking.MovieID)
                    {
                    
                       screen.NoOfSeatsAvailable+=booking.SeatCount;
                       booking.TotalAmount-=20;
                       tempUser.WalletBalance+=booking.TotalAmount;
                       booking.BookingStatus=Status.Cancelled;
                       System.Console.WriteLine("Order cancelled successfully");
                       
                       
                    }
                    
                }
                
            }
            else
            {
              System.Console.WriteLine("No booking availablw");
            }

            }
        }
        
        public static void BookingHistory(UserDetails tempUser)
        {
            System.Console.WriteLine("");
            foreach(BookingDetails booking in bookList)
            {
               if(tempUser.UserID==booking.UserID)
               {
                System.Console.WriteLine($"{booking.BookingID} | {booking.MovieID} | {booking.TheatreID} | {booking.SeatCount } | {booking.TotalAmount} | {booking.BookingStatus}");
               }

            }
        }
        public static void DefaultValues()
        {
            UserDetails user1 = new UserDetails("Ravichandran",30,8599488003,1000);
            UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
            userList.Add(user1);
            userList.Add(user2);

            TheatreDetails theatre1=new TheatreDetails("Inox","Anna nagar");
            TheatreDetails theatre2 = new TheatreDetails("Ega Theatre","Chetpet");
            TheatreDetails theatre3 = new TheatreDetails("Kamala","Vadapalani");
            theatreList.Add(theatre1);
            theatreList.Add(theatre2);
            theatreList.Add(theatre3);

            MovieDetails movie1=new MovieDetails("Bahubali2","telugu");
            MovieDetails movie2 = new MovieDetails("Ponniyin Selvan","Tamil");
            MovieDetails movie3=new MovieDetails("Cobra","tamil");
            MovieDetails movie4=new MovieDetails("Vikram","Hindi Dubbed");
            MovieDetails movie5=new MovieDetails("Vikram","tamil");
            MovieDetails movie6=new MovieDetails("Beast","English");
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            
        ScreeningDetails screen1 = new ScreeningDetails(movie1.MovieID,theatre1.TheatreID,5,200);
        ScreeningDetails screen2=new ScreeningDetails(movie2.MovieID,theatre1.TheatreID,2,300);
        ScreeningDetails screen3=new ScreeningDetails(movie6.MovieID,theatre1.TheatreID,1,50);
        ScreeningDetails screen4= new ScreeningDetails(movie1.MovieID,theatre2.TheatreID,11,400);
        ScreeningDetails screen5= new ScreeningDetails(movie2.MovieID,theatre2.TheatreID,20,300);
        ScreeningDetails screen6= new ScreeningDetails(movie4.MovieID,theatre2.TheatreID,2,500);
        ScreeningDetails screen7=new ScreeningDetails(movie5.MovieID,theatre3.TheatreID,11,100);
        ScreeningDetails screen8=new ScreeningDetails(movie2.MovieID,theatre3.TheatreID,20,200);
        ScreeningDetails screen9=new ScreeningDetails(movie2.MovieID,theatre3.TheatreID,2,350);
        screenList.Add(screen1);
        screenList.Add(screen2);
        screenList.Add(screen3);
        screenList.Add(screen4);
        screenList.Add(screen5);
        screenList.Add(screen6);
        screenList.Add(screen7);
        screenList.Add(screen8);
        screenList.Add(screen9);
        }
    }
}