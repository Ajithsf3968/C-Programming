using System;
using System.Collections.Generic;
namespace OnlineMedicalStore;

    public static class Operations
    {
        public static List<UserDetails>userList=new List<UserDetails>();
        public static List <OrderDetails>orderList=new List<OrderDetails>();
        public static List<MedicineDetails>medicineList=new List<MedicineDetails>();
        public static void MainMenu()
        {
          string condition="yes";
          do
          {
            System.Console.WriteLine("----Main Menu----");
            System.Console.WriteLine("Enter your choice \n 1. Registration \n 2.Login \n 3.Exit");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
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
                    condition="no";
                    break;
                }
            }
         } while (condition=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("enter Your age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter city:");
            string city =Console.ReadLine();
            System.Console.WriteLine("enter your mobile number");
            long number=long.Parse(Console.ReadLine());
            System.Console.WriteLine("enter your balance amount");
            double balance=double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name,age,city,number,balance);
            System.Console.WriteLine("your ID"+ " "+user.UserID);
            userList.Add(user);

            
        } 
        public static void Login()
        {
            int flag=0;
            System.Console.WriteLine("Enter your Id");
           string userId=Console.ReadLine().ToUpper();
           UserDetails userData;
           foreach(UserDetails user in userList)
           {
                if(user.UserID==userId)
                {
                    flag=1;
                    userData=user;
                    SubMenu(userData);
                    break;
                }
                else
                {
                    flag=0;
                }
            }
           if(flag==0)
           {
            System.Console.WriteLine("Invalid user Id ,please enter a valid one");
           }
           
        }
        public static void SubMenu(UserDetails userData)
        {
            string menuChoice="yes";
            do
            {
                System.Console.WriteLine("----Sub Menu----");
                System.Console.WriteLine("Choose your option \n 1. Show medicine list \n 2.purchase medicine \n 3. cancel purchase \n 4.show purchase history \n 5.Recharge 6.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                   case 1:
                   {
                    ShowMedicineList(userData);
                    break;
                   }
                   case 2:
                   {
                    PurchaseMedicine(userData);
                    break;
                   }
                   case 3:
                   {
                    CancelPurchase(userData);
                    break;
                   }
                   case 4:
                   {
                    ShowPurchaseHistory(userData);
                    break;
                   }
                   case 5:
                   {
                    Recharge(userData);
                    break;
                   }
                   case 6:
                   {
                    menuChoice="no";
                    break;
                   }

                }
                
            } while (menuChoice=="yes");
        }
        public static void ShowMedicineList(UserDetails userData)
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine("------------------------------------------------------------------");
                System.Console.WriteLine($"|{"Medicine ID"} | {"Medicine Name"} | {"Medicine Availability"} | {"Medicine Price"} | {"Date of Expiry"} | ");
                System.Console.WriteLine($"|{medicine.MedicineID} | {medicine.MedicineName} | {medicine.AvailableCount} | {medicine.MedicinePrice} | {medicine.DateOfExpiry} | ");
                System.Console.WriteLine("-------------------------------------------------------------------");
            }
        }
        public static void  PurchaseMedicine(UserDetails userData)
        {
           double amount;
           
            int flag=0;
            ShowMedicineList(userData);
            System.Console.WriteLine("Enter medicine id of medicine which you want to buy: ");
            string medicineId=Console.ReadLine();
            System.Console.WriteLine("enter number of counts");
            int count = int.Parse(Console.ReadLine());
           foreach(MedicineDetails medicine in medicineList)
           {
            if(medicineId==medicine.MedicineID )
            {
                flag=1;
                if(count<=medicine.AvailableCount)
                {
                    if(userData.Balance>=medicine.MedicinePrice)
                    {

                       if(DateTime.Now<medicine.DateOfExpiry)
                       {
                           amount=count*medicine.MedicinePrice;
                           DateTime orderDate=DateTime.Now;
                           medicine.AvailableCount=medicine.AvailableCount-count;
                           userData.Balance-=medicine.MedicinePrice;
                           OrderDetails order = new OrderDetails(userData.UserID,medicine.MedicineID,medicine.AvailableCount,amount,orderDate,Status.Puchased);
                           orderList.Add(order);
                           System.Console.WriteLine("Medicine was purchased succesfully");
                           
                       }

                    }
                }
            }
            else
            {
                flag=0;
            }
           }
           if(flag==0)
           {
            System.Console.WriteLine("Medicine not avialble");
           }


             
        }
        public static void CancelPurchase(UserDetails userData)
        {
            int flag=0;
            ShowPurchaseHistory(userData);
            System.Console.WriteLine("enter order id");
            string orderId=Console.ReadLine();
            foreach(OrderDetails order in orderList)
            {
                if(orderId==order.OrderID && order.OrderStatus==Status.Puchased)
                {
                  flag=1;
                   foreach(MedicineDetails medicine in medicineList)
                   {
                    if(medicine.MedicineID==order.MedicineID)
                    {
                        medicine.AvailableCount+=order.MedicineCount;
                        userData.Balance+=order.TotalPrice;
                        order.OrderStatus=Status.Cancelled;
                        System.Console.WriteLine("Order ID"+order.OrderID+"was successfully cahnged");
                    }
                   }
                }
                else
                {
                    flag=1;
                }

            }
            if(flag==0)
            {
                System.Console.WriteLine("You have not taken order yet");
            }
        }
        public static void ShowPurchaseHistory(UserDetails userData)
        {
            int flag=0;
           
            foreach(OrderDetails order in orderList)
            {
                if(userData.UserID==order.UserID)
                {
                    flag=1;

                    System.Console.WriteLine("------------------------------");
                    System.Console.WriteLine($"| {"orderID"} | {"medicine Id"} | {"MedicineCount"} | {"TotalPrice"} |{"OrderData"} |{"orderStatus"}");
                    System.Console.WriteLine($"| {order.OrderID} | {order.MedicineID} |{order.MedicineCount} | {order.TotalPrice} | {order.OrderDate} | {order.OrderStatus}");
                }
                else
                {
                    flag=0;
                }
                
            }
            if(flag==0)
            {
                System.Console.WriteLine("History not found");
            }

       }
       public static void Recharge(UserDetails userData)
       {
            int rechargeAmount;
            System.Console.WriteLine("enter recharge amount");
            rechargeAmount=int.Parse(Console.ReadLine());
            userData.Balance+=rechargeAmount;
       }
         
        public static void DefaultValues()
        {
              UserDetails user1=new UserDetails("Ravi",33,"Theni",3849383738,400);
              UserDetails user2=new UserDetails("Baskar",33,"chennai",8736293736,500);

              userList.Add(user1);
              userList.Add(user2);

              MedicineDetails medicine1=new MedicineDetails("paracitamol",40,5,new DateTime(2022,06,30));
              MedicineDetails medicine2=new MedicineDetails("calpol",10,5,new DateTime(2022,05,30));
              MedicineDetails medicine3=new MedicineDetails("Gelusil",3,540,new DateTime(2022,04,30));
              MedicineDetails medicine4=new MedicineDetails("Metrogol",5,5,new DateTime(2022,10,30));
              MedicineDetails medicine5=new MedicineDetails("Poridin Iodine",10,50,new DateTime(2022,10,30));

              medicineList.Add(medicine1);
              medicineList.Add(medicine2);
              medicineList.Add(medicine3);
              medicineList.Add(medicine4);
              medicineList.Add(medicine5);

              OrderDetails order1=new OrderDetails(user1.UserID,medicine1.MedicineID,3,15,new DateTime(2022,05,13),Status.Puchased);
              OrderDetails order2=new OrderDetails(user1.UserID,medicine2.MedicineID,2,15,new DateTime(2022,05,13),Status.Cancelled);
              OrderDetails order3=new OrderDetails(user1.UserID,medicine4.MedicineID,2,100,new DateTime(2022,05,13),Status.Puchased);
               OrderDetails order4=new OrderDetails(user2.UserID,medicine3.MedicineID,3,120,new DateTime(2022,05,15),Status.Cancelled);
               OrderDetails order5=new OrderDetails(user2.UserID,medicine5.MedicineID,5,250,new DateTime(2022,05,15),Status.Puchased);
               OrderDetails order6=new OrderDetails(user2.UserID,medicine3.MedicineID,3,15,new DateTime(2022,05,15),Status.Cancelled);

               orderList.Add(order1);
               orderList.Add(order2);
               orderList.Add(order3);
               orderList.Add(order4);
               orderList.Add(order5);
               orderList.Add(order6);







        }
    }
