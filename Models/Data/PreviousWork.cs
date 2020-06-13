namespace JobApplying.Models
{
    public class PreviousWork
    {
        public int Id { set; get; }
        public string PlaceAndLefReason { set; get; }
        public int ApplierId { set; get; }
        public Applier Applier { set; get; }
    }
}