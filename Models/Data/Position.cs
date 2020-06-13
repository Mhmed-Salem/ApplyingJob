using System.Collections.Generic;

namespace JobApplying.Models
{
    public class Position
    {
        public Position()
        {
            Appliers=new List<Applier>();
        }
        public int Id { set; get; }
        public string Pos { set; get; }
        public IList<Applier> Appliers { set; get; }
    }

   
}