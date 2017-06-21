namespace HisPlus.Domain
{
    using AppPlus.Infrastructure.Contracts.Messages;

    public class BsUserImage : EntityBase<int>
    {
        public BsUserImage()
        {    
        }

        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
