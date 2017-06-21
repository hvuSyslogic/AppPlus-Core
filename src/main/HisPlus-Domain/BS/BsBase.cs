namespace HisPlus.Domain
{
    using AppPlus.Infrastructure.Contract.Messages;

    public class BsBase : EntityBase<int>
    {
        public BsBase()
        {    
        }

        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
