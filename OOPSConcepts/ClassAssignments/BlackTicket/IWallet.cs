namespace BlackTicket
{
    public interface IWallet
    {
        
         public double WalletBalance { get;  }
         void RechargeWallet();
         
         
    }
}