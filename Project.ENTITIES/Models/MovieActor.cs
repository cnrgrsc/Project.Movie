using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MovieActor:BaseEntity
    {
        public int ActorID { get; set; }
        public int MovieID { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Movie  Movie{ get; set; }
    }
}
