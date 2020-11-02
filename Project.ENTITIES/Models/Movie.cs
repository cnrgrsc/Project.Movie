using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public int DirectorID { get; set; }

        public virtual List<MovieActor> MovieActors { get; set; }
        public virtual Director  Director{ get; set; }
    }
}
