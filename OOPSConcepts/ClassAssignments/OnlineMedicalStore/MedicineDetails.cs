using System;
namespace OnlineMedicalStore;

    public class MedicineDetails
    {
        private static int s_medicineID=100;
        public string MedicineID { get; }
        public string MedicineName { get; set; }
        
        
        public int AvailableCount { get; set; }
        public double MedicinePrice { get; set; }
        public DateTime DateOfExpiry { get; set; }
        
    public MedicineDetails(string medicineName,int availableCount,double price,DateTime ExpiryDate )
    {
        s_medicineID++;
        MedicineID="MD"+s_medicineID;
        AvailableCount=availableCount;
        MedicinePrice=price;
        DateOfExpiry=ExpiryDate;
    }
        
        
        
        
    }
