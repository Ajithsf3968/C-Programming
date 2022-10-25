using System;
namespace EBBill;
 class Program
 {
    public static void Main(string[] args)
    {
        int surCharge;
        double bill,netAmount,unitCharge;
        System.Console.WriteLine("enter the unit");
        int unit=int.Parse(Console.ReadLine());
        
        if(unit<100)
        {
            netAmount=100;
        }
       
        if(unit>100 && unit<199)
        {
            unitCharge=1.20;
        }
        else if(unit>=199 && unit<400)
        {
            unitCharge=1.50;
        }
        else if(unit>=400 && unit<600)
        {
            unitCharge=1.80;
        }
        else if(unit>=600)
        {
           unitCharge=2.0;
        }


        bill=unit*unitCharge;
        surCharge=(15/bill)*100;
                
        if(bill>400)
        {
            
        }

    }
 }
