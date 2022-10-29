namespace CafeteriaCardManagement
{
    public interface IBalance
    {
         public double WalletBalance { get; }
         public void WalletRecharge();
         
         
    }
}