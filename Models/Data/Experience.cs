namespace JobApplying.Models
{
    public class Experience
    {
        public int Id { set; get; }
        public string ExperienceItem { set; get; }
        public int ApplierId { set; get; }
        public Applier Applier { set; get; }
    }
}