namespace JobApplying.Models
{
    public class PreviousWork
    {
        public int Id { set; get; }
        public string PlaceName { set; get; }
        public string LeftReason { set; get; }
        public int ApplierId { set; get; }
        public Applier Applier { set; get; }
    }
}