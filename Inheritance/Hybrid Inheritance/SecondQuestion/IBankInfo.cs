namespace Hybrid
{
    public interface IBankInfo
    {
         public string BankName { get; set; }
         public long IFSCcode { get; set; }
         public string Branch{ get; set; }
    }
}