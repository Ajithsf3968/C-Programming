using System;
using System.Collections.Generic;
namespace CafeteriaCardManagement
{

    public static  class Operations
    {
        public static List<UserDetails>userList=new List<UserDetails>();
        public static List<FoodDetails>foodList=new List<FoodDetails>();
        public static List<OrderDetails>orderList=new List<OrderDetails>();
        public static List<CartItem>cartList=new List<CartItem>();
        //mainmenu called
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("----MainMenu----");
                //asking user choice
                System.Console.WriteLine("Enter your option \n 1.Registration \n 2.Login \n 3.Exit");
                int option=int.Parse(Console.ReadLine());
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
        public static void Registration()
        {
            //getting details from user
            System.Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father name");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your mobile number");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mailID");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter your gender");
            Gender userGender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your work station number");
            string stationNumber=Console.ReadLine();
            System.Console.WriteLine("Enter your wallet balance");
            double balance=double.Parse(Console.ReadLine());
            //creating object for userDetails class
            UserDetails user =new UserDetails(name,fatherName,userGender,mobile,mailID,balance,stationNumber);
            // Add the object into UserDetails list
            userList.Add(user);
            // display user id
            System.Console.WriteLine("Registration successfully completed");
            System.Console.WriteLine("Your User Id:"+user.UserID);
            
        }
        // Login called
        public static void Login()
        {
            System.Console.WriteLine("Login portal");
            //getting user Id from user
            System.Console.WriteLine("Enter your User ID");
            string yourUserID=Console.ReadLine();
            int temp=0;
            UserDetails userData;
            foreach(UserDetails user in userList)
            {
                //validating user id
                if(user.UserID==yourUserID)
                {
                    
                    temp=1;
                    userData=user;
                    SubMenu(userData);
                    break;
               }
            }
            if(temp==0)
            {
                System.Console.WriteLine("Invalid user ID");
            }
       

        }
        //submenu called
         public static void SubMenu(UserDetails userData)
         {
            System.Console.WriteLine("----submenu----");
            System.Console.WriteLine("Enter your option \n 1.Show my profile \n 2.Food Order\n 3.Cancel Order \n 4.Order History \n 5. Wallet Recharge\n 6. Exit");
            //getting choice from user
            int submenuChoice=int.Parse(Console.ReadLine());
            switch(submenuChoice)
            {
                case 1:
                {
                    ShowMyProfile(userData);
                    break;
                }
                case  2:
                {
                    FoodOrder(userData);
                    break;
                }
                case 3:
                {
                    break;
                }
            }
         }
         //show profile called 
         public static void ShowMyProfile(UserDetails userData)
         {
            
            foreach(UserDetails user in userList)
            {
                //validating user ID 
                if(userData.UserID==user.UserID)
                {
                    // display user details 
                    System.Console.WriteLine($"UserID  UserName  Fathername  Gender  Mobile  mailId  WorkStation number  Walletbalance");
                    System.Console.WriteLine($" | {user.UserID} | {user.Name} | {user.FatherName} | {user.PersonGender} | {user.Mobile} | {user.MailID} | {user.WorkStationNumber} | {user.WalletBalance} | ");
                }
            }
         }
         //Taking order 
         public static void FoodOrder(UserDetails userData)
         {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine($"{food.FoodID} | {food.FoodName} | {food.FoodPrice} | {food.AvailableQuantiy}");


            }
             OrderDetails order = new OrderDetails(userData.UserID,DateTime.Now,0,)
             


         }
        public static void DefaultVales()
        {
            UserDetails user1=new UserDetails("ravi","ettaparajan",Gender.Male,1234587,"ravi@gmail.com",400,"WS101");
            UserDetails user2=new UserDetails("Baskar","sethu",Gender.Male,09876543,"baskar@gmail.com",500,"WS105");
            userList.Add(user1);
            userList.Add(user2);

            FoodDetails food1=new FoodDetails("cofee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("juice",50,100);
            FoodDetails food5=new FoodDetails("puff",40,100);
            FoodDetails food6=new FoodDetails("milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,10);

            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);

            OrderDetails order1=new OrderDetails(user1.UserID,new DateTime(2022/06/15),70);
            OrderDetails order2=new OrderDetails(user2.UserID,new DateTime(2022/06/15),100);
            orderList.Add(order1);
            orderList.Add(order2);

            CartItem cart1=new CartItem(food1.FoodID,order1.OrderID,20,1);
            CartItem cart2=new CartItem(food3.FoodID,order1.OrderID,10,1);
            CartItem cart3=new CartItem(food5.FoodID,order1.OrderID,40,1);
            CartItem cart4=new CartItem(food3.FoodID,order2.OrderID,10,1);
            CartItem cart5=new CartItem(food4.FoodID,order2.OrderID,50,1);
            CartItem cart6 = new CartItem(food5.FoodID,order2.OrderID,50,1);
            
            
            







        }
    }
}